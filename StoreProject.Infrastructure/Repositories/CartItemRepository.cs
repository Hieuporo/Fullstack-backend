using Microsoft.EntityFrameworkCore;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
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
    }
}
