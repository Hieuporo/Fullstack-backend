using MediatR;
using StoreProject.Application.Contracts.Authentication;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.Exceptions;


namespace StoreProject.Application.Auth.Commands.Logout
{
    public class LogoutCommandHandler : IRequestHandler<LogoutCommand, Unit>
    {
        private readonly IJwtService _jwtService;
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;


        public LogoutCommandHandler(IJwtService jwtService, IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            _jwtService = jwtService;
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        public Task<Unit> Handle(LogoutCommand request, CancellationToken cancellationToken)
        {
            var userId = _jwtService.GetCurrentUserId();
            var user = _userRepository.Get(userId);
            if (userId == 0 || user == null)
            {
                throw new BadRequestException("Some thing went wrong");
            }

            

            return Unit.Task;
        }
    }
}
