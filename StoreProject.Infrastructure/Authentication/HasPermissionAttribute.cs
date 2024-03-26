
using Microsoft.AspNetCore.Authorization;
using StoreProject.Domain.Enums;


namespace StoreProject.Infrastructure.Authentication
{
	public sealed class HasPermissionAttribute : AuthorizeAttribute
	{
        public HasPermissionAttribute(PermissionList permission) : base(policy: permission.ToString())
        {
            
        }
    }
}
