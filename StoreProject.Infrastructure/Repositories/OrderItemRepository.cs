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
    public class OrderItemRepository : GenericRepository<OrderItem> , IOrderItemRepository
    {
         private readonly ApplicationDbContext _dbContext;
        public OrderItemRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
