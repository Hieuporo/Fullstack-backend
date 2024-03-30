using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using StoreProject.Application.Contracts.Authentication;
using StoreProject.Application.Models;
using StoreProject.Domain.Constants;
using StoreProject.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;


namespace StoreProject.Infrastructure.Authentication
{
	
	public class JwtService : IJwtService
	{
		private readonly JwtOptions _options;
		private readonly IPermissionService _permissionService;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public JwtService(IOptions<JwtOptions> options, IPermissionService permissionService, IHttpContextAccessor httpContextAccessor)
		{
			_options = options.Value;
			_permissionService = permissionService;
			_httpContextAccessor = httpContextAccessor;
        }


		public async Task<string> GenerateAccessToken(User user)
		{
			var claims = new  List<Claim>
			{
				new("Id", user.Id.ToString()),
				new(JwtRegisteredClaimNames.Email, user.Email)
			};

			HashSet<string> permissions = await _permissionService.GetPermissionsAsync(user.Id);

			foreach(string permission in permissions)
			{
				claims.Add(new(CustomClaimTypes.Permission, permission));
			}

			var signingCredentials = new SigningCredentials(
				new SymmetricSecurityKey(
					Encoding.UTF8.GetBytes(_options.SecretKey)),
				SecurityAlgorithms.HmacSha256);

			var token = new JwtSecurityToken(
				_options.Issuer,
				_options.Audience,
				claims,
				null,
				DateTime.UtcNow.AddHours(10),
				signingCredentials);

			string tokenValue = new JwtSecurityTokenHandler()
				.WriteToken(token);

			return tokenValue;
		}

        public RefreshToken GenerateRefreshToken()
        {
			var refreshToken = new RefreshToken();
            refreshToken.Expires = DateTime.UtcNow.AddDays(30);
            refreshToken.Created = DateTime.UtcNow;
			refreshToken.Token = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64));

            return refreshToken;
        }

        public int GetCurrentUserId()
        {
            var userId = Int32.Parse(_httpContextAccessor.HttpContext.User.FindFirst("Id").Value);

            if (userId != null)
            {
                return userId;
            }

            return 0;
        }

        public RefreshToken Refresh(string accessToken, string refreshToken)
        {
            throw new NotImplementedException();
        }

        public void RevokeToken(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
