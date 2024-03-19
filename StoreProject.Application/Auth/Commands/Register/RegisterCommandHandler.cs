using MediatR;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Domain.Entities;
using System.Reflection.Metadata;
using System.Reflection;
using StoreProject.Application.Utils;


namespace StoreProject.Application.Auth.Commands.Register
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;

        public RegisterCommandHandler(IUnitOfWork unitOfWork, IUserRepository userRepository)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
        }

        public async Task<int> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {

            User user = new User
            {
                Email = request.Email,
                Password = PasswordUtil.MD5Hash(request.Password),
            };
            await _userRepository.Add(user);
            await _unitOfWork.SaveChangesAsync();
            return user.Id;
        }
    }
}
