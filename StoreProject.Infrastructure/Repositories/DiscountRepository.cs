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

        public async Task<List<Discount>> GetAvailableDiscounts(int userId)
        {
            var discounts = _dbContext.Discounts.Where(d => d.StartDate > DateTime.Now && DateTime.Now < d.EndDate).ToList();
            var availableDiscount = new List<Discount>();
            foreach (var discount in discounts)
            {
               var userDiscount = await _dbContext.UserDiscounts.FirstOrDefaultAsync(u => u.UserId == userId && u.DiscountId == discount.Id);

               if(userDiscount == null)
               {
                    availableDiscount.Add(discount);
               }
            }

            return availableDiscount;
        }

        public async Task<Discount?> GetDiscountByCode(string code)
        {
            var discount = await _dbContext.Discounts.FirstOrDefaultAsync(u => u.DiscountCode == code);

            return discount;
        }
    }
}
