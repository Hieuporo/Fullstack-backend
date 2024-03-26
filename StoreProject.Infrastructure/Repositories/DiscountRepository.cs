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
    public class DiscountRepository : GenericRepository<Discount>, IDiscountRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public DiscountRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Discount?> GetDiscountByCode(string code)
        {
            var coupon = await _dbContext.Discounts.FirstOrDefaultAsync(u => u.DiscountCode == code);


            return coupon;
        }
    }
}
