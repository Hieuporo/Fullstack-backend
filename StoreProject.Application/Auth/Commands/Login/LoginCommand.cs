using MediatR;
using StoreProject.Application.DTOs.User;


namespace StoreProject.Application.Auth.Commands.Login
{
    public class LoginCommand : IRequest<UserDto>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
