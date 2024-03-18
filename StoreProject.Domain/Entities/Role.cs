using StoreProject.Domain.Common;

namespace StoreProject.Domain.Entities
{
	public class Role : BaseDomainEntity
	{
		public string Name { get; set; }

		public ICollection<UserRole> UserRoles { get; set; }
		public ICollection<RolePermission> RolePermissions { get; set; }

	}
}
