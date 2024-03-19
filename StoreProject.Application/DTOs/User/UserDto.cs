
namespace StoreProject.Application.DTOs.User
{
    public class UserDto 
    {
        public string Email { get; set; }
        public string? Address { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Avatar { get; set; }
        public string? RefreshToken { get; set; }

    }
}
