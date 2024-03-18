using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using StoreProject.Domain.Constants;

namespace StoreProject.Infrastructure.Authentication
{
	public class PermissionAuthorizationHandler : AuthorizationHandler<PermissionRequirement>
	{
		protected override Task HandleRequirementAsync(
			AuthorizationHandlerContext context, 
			PermissionRequirement requirement)
		{
			HashSet<string> permissions = context
					.User
					.Claims
					.Where(x => x.Type == CustomClaimTypes.Permission)
					.Select(x => x.Value)
					.ToHashSet();
						

			if (permissions.Contains(requirement.Permission))
			{
					context.Succeed(requirement);
			}

			return Task.CompletedTask;
		}
	} 
}
