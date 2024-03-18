namespace StoreProject.Domain.Entities
{
	public class RolePermission 
	{

		public Role Role { get; set; }
		public Permission Permission { get; set; }
		public int RoleId { get; set; }
		public int PermissionId {  get; set; }
	}
}
