using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using StoreProject.Application.Contracts.Authentication;
using StoreProject.Domain.Constants;
using StoreProject.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace StoreProject.Infrastructure.Authentication
{
	
	public class JwtTokenGenerator : IJwtTokenGenerator
	{
		private readonly JwtOptions _options;
		private readonly IPermissionService _permissionService;

		public JwtTokenGenerator(IOptions<JwtOptions> options, IPermissionService permissionService)
		{
			_options = options.Value;
			_permissionService = permissionService;
		}


		public async Task<string> GenerateAccessToken(User user)
		{
			var claims = new  List<Claim>
			{
				new(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
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

		
	}
}
