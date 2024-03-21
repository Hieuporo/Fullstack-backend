using StoreProject.Domain.Entities;

namespace StoreProject.Application.Contracts.Authentication
{
    public interface IJwtService
    {
        Task<string> GenerateAccessToken(User user);
        string GenerateRefreshToken();
        int GetCurrentUserId();
    }
}
