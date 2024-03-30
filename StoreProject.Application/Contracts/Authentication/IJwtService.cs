using StoreProject.Application.Models;
using StoreProject.Domain.Entities;

namespace StoreProject.Application.Contracts.Authentication
{
    public interface IJwtService
    {
        Task<string> GenerateAccessToken(User user);
        RefreshToken GenerateRefreshToken();
        RefreshToken Refresh(string accessToken, string refreshToken);
        void RevokeToken(int userId);
        int GetCurrentUserId();
    }
}
