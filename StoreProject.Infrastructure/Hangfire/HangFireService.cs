using Hangfire;
using StoreProject.Application.Contracts.Service;
using StoreProject.Domain.Enums;
using StoreProject.Infrastructure.Data;


namespace StoreProject.Infrastructure.Hangfire
{
    public class HangFireService : IHangfireService
    {
        private readonly ApplicationDbContext _context;

        public HangFireService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CheckExpireEmail(int otpId)
        {
            var jobId = BackgroundJob.Schedule(() => HandleOtp(otpId), TimeSpan.FromMinutes(5));
        }

        public void HandleOtp(int otpId)
        {
            var otp = _context.Otps.Find(otpId);

            if (otp.OtpStatus == OtpStatus.Pending)
            {
                otp.OtpStatus = OtpStatus.Block;
                _context.Update(otp);
                _context.SaveChanges();
            }
        }
    }
}
