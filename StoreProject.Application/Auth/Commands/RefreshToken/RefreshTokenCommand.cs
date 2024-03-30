

using MediatR;
using StoreProject.Application.DTOs.User;

namespace StoreProject.Application.Auth.Commands.RefreshToken
{
    public class RefreshTokenCommand : IRequest<AuthDto>
    {
        public string RefreshToken { get; set; }
        public string AccessToken { get; set; }

    }
}
