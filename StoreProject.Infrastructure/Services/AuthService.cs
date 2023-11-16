using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using StoreProject.Application.Constants;
using StoreProject.Application.Contracts.Infrastructure.Identity;
using StoreProject.Application.Exceptions;
using StoreProject.Application.Models.Identity;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Infrastructure.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly JwtSettings _jwtSettings;
		private readonly IHttpContextAccessor _httpContextAccessor;
		public AuthService(UserManager<ApplicationUser> userManager,
            IOptions<JwtSettings> jwtSettings,
            SignInManager<ApplicationUser> signInManager,
			IHttpContextAccessor httpContextAccessor
			)
        {
            _userManager = userManager;
            _jwtSettings = jwtSettings.Value;
            _signInManager = signInManager;
			_httpContextAccessor = httpContextAccessor;

		}

		public async Task<AuthResponse> Login(AuthRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user == null)
            {
                throw new Exception($"User with {request.Email} not found.");
            }

            var result = await _signInManager.PasswordSignInAsync(user.UserName, request.Password, false, lockoutOnFailure: false);

            if (!result.Succeeded)
            {
                throw new Exception($"Credentials for '{request.Email} aren't valid'.");
            }


			JwtSecurityToken jwtSecurityToken = await GenerateAccessToken(user);
			var refreshToken = GenerateRefreshToken();
			user.RefreshToken = refreshToken;
			user.RefreshTokenExpiry = DateTime.UtcNow.AddMonths(1);

			AuthResponse response = new AuthResponse
            {
               RefreshToken = refreshToken,
			   AccessToken = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
			   Expiration = jwtSecurityToken.ValidTo,
			};

            return response;
        }

        public async Task<RegistrationResponse> Register(RegistrationRequest request)
        {
            var existingUser = await _userManager.FindByNameAsync(request.UserName);

            if (existingUser != null)
            {
                throw new Exception($"Username '{request.UserName}' already exists.");
            }

            var user = new ApplicationUser
            {
                Email = request.Email,
                Name = request.Name,
                PhoneNumber = request.PhoneNumber,
                Address = request.Address,
                UserName = request.UserName,
                EmailConfirmed = true
            };

            var existingEmail = await _userManager.FindByEmailAsync(request.Email);

            if (existingEmail == null)
            {
                var result = await _userManager.CreateAsync(user, request.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, Role.RoleCustomer);
                    return new RegistrationResponse() { UserId = user.Id };
                }
                else
                {
                    throw new Exception($"{result.Errors}");
                }
            }
            else
            {
                throw new Exception($"Email {request.Email} already exists.");
            }
        }

        public async Task<IList<ApplicationUser>> ListUser()
        {
            var users = await _userManager.GetUsersInRoleAsync(Role.RoleCustomer);

            return users;
        }


        private async Task<JwtSecurityToken> GenerateAccessToken(ApplicationUser user)
        {
            var userClaims = await _userManager.GetClaimsAsync(user);
            var roles = await _userManager.GetRolesAsync(user);

            var roleClaims = new List<Claim>();

            for (int i = 0; i < roles.Count; i++)
            {
                roleClaims.Add(new Claim(ClaimTypes.Role, roles[i]));
            }

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(CustomClaimTypes.Uid, user.Id)
            }
            .Union(userClaims)
            .Union(roleClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_jwtSettings.DurationInMinutes),
                signingCredentials: signingCredentials);
            return jwtSecurityToken;
        }

		private string GenerateRefreshToken()
		{
			var randomNumber = new byte[64];

			using var generator = RandomNumberGenerator.Create();

			generator.GetBytes(randomNumber);

			return Convert.ToBase64String(randomNumber);
		}

		
		public async Task<bool> Revoke()
		{

			var userId = _httpContextAccessor.HttpContext.User.FindFirst(CustomClaimTypes.Uid).Value;

            var user = await _userManager.FindByIdAsync(userId);

            if(user != null)
            {
                return false;
            }

			user.RefreshToken = null;
			await _userManager.UpdateAsync(user);

			return true;
		}

		private ClaimsPrincipal? GetPrincipalFromExpiredToken(string token)
		{
			var secret = _jwtSettings.Issuer ?? throw new InvalidOperationException("Secret not configured");

			var validation = new TokenValidationParameters
			{
				ValidIssuer = _jwtSettings.Issuer,
				ValidAudience = _jwtSettings.Audience,
				IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret)),
				ValidateLifetime = false
			};

			return new JwtSecurityTokenHandler().ValidateToken(token, validation, out _);
		}

		public async Task<object> Refresh(RefreshRequest model)
		{

			var principal = GetPrincipalFromExpiredToken(model.AccessToken);

			var user = await _userManager.FindByIdAsync(principal.FindFirstValue(CustomClaimTypes.Uid));

            if (user is null || user.RefreshToken != model.RefreshToken || user.RefreshTokenExpiry < DateTime.UtcNow)
                throw new UnauthorizedException("Refresh token has expired or does not exist");


			JwtSecurityToken jwtSecurityToken = await GenerateAccessToken(user);
			var refreshToken = GenerateRefreshToken();
			user.RefreshToken = refreshToken;
			user.RefreshTokenExpiry = DateTime.UtcNow.AddMonths(1);

			return new AuthResponse
			{
				AccessToken = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
				Expiration = jwtSecurityToken.ValidTo,
				RefreshToken = refreshToken
			};
		}

		private async Task<string> SendVerificationEmail(ApplicationUser user, string origin)
		{
			var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);

			code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
			var route = "api/Auth/confirm-email/";

			var _enpointUri = new Uri(string.Concat($"{origin}/", route));
			var verificationUri = QueryHelpers.AddQueryString(_enpointUri.ToString(), "userId", user.Id);
			verificationUri = QueryHelpers.AddQueryString(verificationUri, "code", code);
			//Email Service Call Here
			return verificationUri;
		}

		public async Task<string> ConfirmEmailAsync(string userId, string code)
		{
			var user = await _userManager.FindByIdAsync(userId);
			code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
			var result = await _userManager.ConfirmEmailAsync(user, code);
			if (result.Succeeded)
			{
				return $"Account Confirmed for {user.Email}. You can now use the /api/Account/authenticate endpoint.";
			}
			else
			{
				throw new Exception($"An error occured while confirming {user.Email}.");
			}
		}

	}
}
