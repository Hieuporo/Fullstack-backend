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
    public class OrderItemRepository : GenericRepository<OrderItem> , IOrderItemRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public OrderItemRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<OrderItem>> AddRange(List<OrderItem> orderItems)
        {
            await _dbContext.OrderItems.AddRangeAsync(orderItems);
            return orderItems;
        }
    }
}
