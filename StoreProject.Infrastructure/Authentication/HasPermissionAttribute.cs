
using Microsoft.AspNetCore.Authorization;
using StoreProject.Domain.Constants;


namespace StoreProject.Infrastructure.Authentication
{
	public sealed class HasPermissionAttribute : AuthorizeAttribute
	{
        public HasPermissionAttribute(PermissionList permission) : base(policy: permission.ToString())
        {
            
        }
    }
}
