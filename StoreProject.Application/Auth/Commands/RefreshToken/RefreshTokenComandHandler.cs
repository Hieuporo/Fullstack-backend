using MediatR;
using StoreProject.Application.Contracts.Authentication;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.DTOs.User;
using StoreProject.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Auth.Commands.RefreshToken
{
    public class RefreshTokenComandHandler : IRequestHandler<RefreshTokenCommand, AuthDto>
    {
        private readonly IJwtService _jwtService;
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;


        public RefreshTokenComandHandler(IJwtService jwtService, IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            _jwtService = jwtService;
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<AuthDto> Handle(RefreshTokenCommand request, CancellationToken cancellationToken)
        {
            var userId = _jwtService.GetCurrentUserId();
            var user = await _userRepository.Get(userId);
            if (user == null)
            {
                throw new BadRequestException("User not found");
            }

            if(request.RefreshToken != user.RefreshToken)
            {
                throw new UnauthorizedException("Refresh token is incorrect");
            }

            if (user.TokenExpires < DateTime.Now) 
            {
                throw new UnauthorizedException("Refresh token expired");
            }

            var userResponse = new UserDto()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Avatar = user.Avatar,
                Address = user.Address,
            };

            var refreshToken = _jwtService.GenerateRefreshToken();
            var accessToken = await _jwtService.GenerateAccessToken(user);

            var auth = new AuthDto
            {
                RefreshToken = refreshToken.Token,
                AccessToken = accessToken,
                User = userResponse
            };

            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return auth;
        }
    }
}
