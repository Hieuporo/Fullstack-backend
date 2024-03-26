using MediatR;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Domain.Entities;
using StoreProject.Application.Utils;
using StoreProject.Application.Contracts.Service;
using StoreProject.Application.Exceptions;
using StoreProject.Domain.Enums;


namespace StoreProject.Application.Auth.Commands.CreatePassword
{
    public class CreatePasswordCommandHandler : IRequestHandler<CreatePasswordCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;
        private readonly IOtpRepository _otpRepository;


        public CreatePasswordCommandHandler(IUnitOfWork unitOfWork, IUserRepository userRepository, IHangfireService hangfireService, IOtpRepository otpRepository)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _otpRepository = otpRepository;
        }

        public async Task<int> Handle(CreatePasswordCommand request, CancellationToken cancellationToken)
        {
            var tokenExists = _otpRepository.FindPendingOtpByCodeAndEmail(request.Token ,request.Email);


            if (tokenExists == null)
            {
                throw new BadRequestException("Something went wrong! Please try again");
            };

            User user = new User
            {
                Email = request.Email,
                Password = PasswordUtil.MD5Hash(request.Password),
            };
            tokenExists.OtpStatus = OtpStatus.Active;
            await _otpRepository.Update(tokenExists);
            await _userRepository.Add(user);
            await _unitOfWork.SaveChangesAsync();
            return user.Id;
        }
    }
}
