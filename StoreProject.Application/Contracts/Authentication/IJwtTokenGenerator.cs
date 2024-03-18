using StoreProject.Domain.Entities;

namespace StoreProject.Application.Contracts.Authentication
{
    public interface IJwtTokenGenerator
    {
        Task<string> GenerateAccessToken(User user);
    }
}
