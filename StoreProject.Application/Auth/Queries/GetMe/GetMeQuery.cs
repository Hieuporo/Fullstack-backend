using MediatR;
using StoreProject.Application.DTOs.User;


namespace StoreProject.Application.Auth.Queries.GetMe
{
    public class GetMeQuery : IRequest<UserDto>
    {
    }
}
