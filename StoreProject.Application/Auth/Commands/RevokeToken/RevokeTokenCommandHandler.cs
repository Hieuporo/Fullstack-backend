using MediatR;
using StoreProject.Application.Auth.Commands.RefreshToken;
using StoreProject.Application.Contracts.Authentication;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Auth.Commands.RevokeToken
{
    public class RevokeTokenCommandHandler : IRequestHandler<RevokeTokenCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;
        private readonly IJwtService _jwtService;

        public RevokeTokenCommandHandler(IUnitOfWork unitOfWork, IUserRepository userRepository, IJwtService jwtService)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _jwtService = jwtService;
        }


        public async Task<Unit> Handle(RevokeTokenCommand request, CancellationToken cancellationToken)
        {
            var userId = _jwtService.GetCurrentUserId();
            var user = await _userRepository.Get(userId);
            if (user == null)
            {
                throw new BadRequestException("User not found");
            }

            user.RefreshToken = null;
            user.TokenExpires = null;

            await _userRepository.Update(user);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;

        }
    }
}
