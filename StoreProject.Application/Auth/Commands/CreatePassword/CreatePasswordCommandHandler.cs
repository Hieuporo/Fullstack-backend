using MediatR;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Domain.Entities;
using StoreProject.Application.Utils;
using StoreProject.Application.Contracts.Service;


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

            User user = new User
            {
                Email = request.Email,
                Password = PasswordUtil.MD5Hash(request.Password),
            };
            //Random random = new Random();
            //Otp newOtp = new Otp
            //{
            //    OtpToken = random.Next(0, (int)Math.Pow(2, 24)),
            //    OtpEmail = request.Email,

            //};
            //await _otpRepository.Add(newOtp);

            //_hangfireService.CheckExpireEmail(newOtp.Id);
            await _userRepository.Add(user);
            await _unitOfWork.SaveChangesAsync();
            return user.Id;
        }
    }
}
