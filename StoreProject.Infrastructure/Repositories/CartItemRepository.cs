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
    public class CartItemRepository : GenericRepository<CartItem> , ICartItemRepository
    {
         private readonly ApplicationDbContext _dbContext;
        public CartItemRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CartItem> DeleteById(int cartItemId)
        {
            var cartItem = await _dbContext.CartItems.FindAsync(cartItemId);
            if (cartItem == null)
            {
                return cartItem;
            }
            _dbContext.CartItems.Remove(cartItem);
            await _dbContext.SaveChangesAsync();
            return cartItem;

        }

        public async Task<CartItem> GetCartItem(int cartId, int productItemId)
        {
            return await _dbContext.CartItems.FirstOrDefaultAsync(u => u.CartId == cartId && u.ProductId == productItemId);
        }

        public async Task<CartItem> GetCartItemDetail(int cartItemId)
        {
            return await _dbContext.CartItems.Include(u => u.Product).FirstOrDefaultAsync(u => u.Id == cartItemId);
        }

        public async Task<bool> IsItemOwnedByUser(int cartItemId, int userId)
        {
            var cartItem = await _dbContext.CartItems.Include(u => u.Cart).FirstOrDefaultAsync(u => u.Id == cartItemId);
            if (cartItem == null)
            {
                return false;
            }

            if (cartItem.Cart.UserId == userId)
            {
                return true;
            }
            return false;
        }

        public Task<bool> IsItemOwnedByUser(int cartItemId, string userId)
        {
            throw new NotImplementedException();
        }
    }
}
