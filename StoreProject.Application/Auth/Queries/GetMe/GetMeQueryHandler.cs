using MediatR;
using StoreProject.Application.Contracts.Authentication;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.DTOs.User;
using StoreProject.Application.Exceptions;

namespace StoreProject.Application.Auth.Queries.GetMe
{
    public class GetMeQueryHandler : IRequestHandler<GetMeQuery, UserDto>
    {
        private readonly IJwtService _jwtService;
        private readonly IUserRepository _userRepository;

        public GetMeQueryHandler(IJwtService jwtService, IUserRepository userRepository)
        {
            _jwtService = jwtService;
            _userRepository = userRepository;
        }

        public async Task<UserDto> Handle(GetMeQuery request, CancellationToken cancellationToken)
        {
            var userId = _jwtService.GetCurrentUserId();
            var user = await _userRepository.Get(userId);
            if (user == null)
            {
                throw new BadRequestException("User not found");
            }


            var userResponse = new UserDto()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Avatar = user.Avatar,
                Address = user.Address,
            };

           
            return userResponse;
        }
    }
}
