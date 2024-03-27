using MediatR;
using StoreProject.Application.Contracts.Authentication;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.DTOs.User;
using StoreProject.Application.Exceptions;
using StoreProject.Application.Utils;


namespace StoreProject.Application.Auth.Commands.Login
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, AuthDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;
        private readonly IJwtService _jwtTokenGenerator;


        public LoginCommandHandler(IUnitOfWork unitOfWork, IUserRepository userRepository, IJwtService jwtTokenGenerator)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public async Task<AuthDto> Handle(LoginCommand request, CancellationToken cancellationToken)
        {

            var user = _userRepository.FindByEmail(request.Email) ?? throw new BadRequestException("User not found");

            var truePassword = PasswordUtil.Compare(request.Password, user.Password);

            if (truePassword == false)
            {
                throw new BadRequestException("Password is incorrect");
            }

            var accessToken = await _jwtTokenGenerator.GenerateAccessToken(user);
            var refreshToken = _jwtTokenGenerator.GenerateRefreshToken();

            user.RefreshToken = refreshToken;

            var userResponse = new UserDto()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Avatar = user.Avatar,
                Address = user.Address,
            };

            var auth = new AuthDto
            {
                RefreshToken = refreshToken,
                AccessToken = accessToken,
                User = userResponse
            };

            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return auth;

        }
    }
}
