using Microsoft.EntityFrameworkCore;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Domain.Entities;
using StoreProject.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Infrastructure.Repositories
{
    public class CouponRepository : GenericRepository<Coupon>, ICouponRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public CouponRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Coupon?> GetCouponByCode(string code)
        {
            var coupon = await _dbContext.Coupons.FirstOrDefaultAsync(u => u.CouponCode == code);


            return coupon;
        }
    }
}
