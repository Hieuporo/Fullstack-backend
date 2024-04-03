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
    public class CartRepository : GenericRepository<Cart> , ICartRepository
    {
         private readonly ApplicationDbContext _dbContext;
        public CartRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Cart> CreateCart(int userId)
        {
            var cart = new Cart()
            {
                UserId = userId,
            };

            await _dbContext.Carts.AddAsync(cart);
            await  _dbContext.SaveChangesAsync();
            return cart;
        }

     

        public async Task<Cart> GetCartByUserId(int userId)
        {
            var cart = await _dbContext.Carts.Include(u => u.CartItems).ThenInclude(u => u.Product).FirstOrDefaultAsync(c => c.UserId == userId);

            return cart;
        }

      
        public async Task<decimal> GetTotalMoney(int userId)
        {
            var cart = await _dbContext.Carts.Include(u => u.CartItems)
                .ThenInclude(u => u.Product).FirstOrDefaultAsync(c => c.UserId == userId);


            decimal total = 0;

            foreach(var cartItem in cart.CartItems)
            {
                total +=  cartItem.Product.BaseCost * cartItem.Quantity;
            }

            return total;
        }
       
    }
}
