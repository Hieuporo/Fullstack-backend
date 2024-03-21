using StoreProject.Domain.Common;


namespace StoreProject.Domain.Entities
{
	public class User : BaseDomainEntity
	{
		public string Email { get; set; }
		public string? Password { get; set; }
		public string? Address { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? Avatar { get; set; }
		public string? RefreshToken { get; set; }
		public ICollection<UserRole> UserRoles { get; set; }
		public ICollection<Cart> Carts { get; set; }

    }
}
