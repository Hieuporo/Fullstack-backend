using MediatR;
using StoreProject.Application.Brands.Commands.CreateBrand;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.DTOs.User;
using StoreProject.Application.Exceptions;
using StoreProject.Application.Utils;
using StoreProject.Domain.Entities;


namespace StoreProject.Application.Auth.Commands.Login
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, UserDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;

        public LoginCommandHandler(IUnitOfWork unitOfWork, IUserRepository userRepository)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
        }

        public async Task<UserDto> Handle(LoginCommand request, CancellationToken cancellationToken)
        {

            var user = _userRepository.FindByEmail(request.Email) ?? throw new BadRequestException("User not found");

            var truePassword = PasswordUtil.Compare(request.Password, user.Password);

            if(truePassword == false)
            {
                throw new BadRequestException("Password is incorrect");
            }

            var result = new UserDto()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Avatar = user.Avatar,
                RefreshToken = user.RefreshToken,
                Address = user.Address,
            };

            return result;

        }
    }
}
