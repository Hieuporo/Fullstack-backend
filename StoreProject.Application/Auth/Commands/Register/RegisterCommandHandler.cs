using MediatR;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Domain.Entities;
using StoreProject.Application.Utils;
using StoreProject.Application.Contracts.Service;
using StoreProject.Application.Exceptions;
using StoreProject.Domain.Enums;


namespace StoreProject.Application.Auth.Commands.Register
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;
        private readonly IOtpRepository _otpRepository;
        private readonly IHangfireService _hangfireService;


        public RegisterCommandHandler(IUnitOfWork unitOfWork, IUserRepository userRepository, IHangfireService hangfireService, IOtpRepository otpRepository)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _hangfireService = hangfireService;
            _otpRepository = otpRepository;
        }

        public async Task<int> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var userExists = _userRepository.FindByEmail(request.Email);

            if (userExists != null)
            {
                throw new BadRequestException("Email is already used");
            }
            var tokenExists = _otpRepository.FindPendingOtpByEmail(request.Email);


            if (tokenExists != null)
            {
                throw new BadRequestException("Please try again in 5 minutes");
            };

            Random random = new Random();
            Otp newOtp = new Otp
            {
                OtpToken = random.Next(100000, 999999),
                OtpEmail = request.Email,
                OtpStatus = OtpStatus.Pending
            };

            await _otpRepository.Add(newOtp);
            await _unitOfWork.SaveChangesAsync();

            _hangfireService.CheckExpireEmail(newOtp.Id);
            return newOtp.Id;
        }
    }
}
