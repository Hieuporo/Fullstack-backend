using Microsoft.EntityFrameworkCore;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Domain.Entities;
using StoreProject.Domain.Enums;
using StoreProject.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Infrastructure.Repositories
{
    public class OtpRepository : GenericRepository<Otp> , IOtpRepository
    {
         private readonly ApplicationDbContext _dbContext;
        public OtpRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Otp FindPendingOtpByCodeAndEmail(int code, string email)
        {
            var otp = _dbContext.Otps.Where(u => u.OtpEmail == email && 
                                            u.OtpStatus == OtpStatus.Pending && 
                                            u.OtpToken == code).FirstOrDefault();
            return otp;
        }

        public Otp FindPendingOtpByEmail(string email)
        {
            var otp = _dbContext.Otps.Where(u => u.OtpEmail == email && u.OtpStatus == OtpStatus.Pending).FirstOrDefault();
            return otp;
        }
    }
}
