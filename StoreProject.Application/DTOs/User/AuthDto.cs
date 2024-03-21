namespace StoreProject.Application.DTOs.User
{
    public class AuthDto
    {
        public string RefreshToken { get; set; }
        public string AccessToken { get; set; }
        public UserDto User { get; set; }
    }
}
