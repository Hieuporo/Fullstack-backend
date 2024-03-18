using StoreProject.Domain.Common;


namespace StoreProject.Domain.Entities
{
	public class Permission : BaseDomainEntity
	{
		public string Name { get; set; }
		public ICollection<RolePermission> RolePermissions { get; set; }

	}
}
