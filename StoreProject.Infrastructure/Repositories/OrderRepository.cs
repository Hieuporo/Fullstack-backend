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
    public class OrderRepository : GenericRepository<Order> , IOrderRepository
    {
         private readonly ApplicationDbContext _dbContext;
        public OrderRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Order> ClientGetAllOrdersWithDetail(string userId)
        {
                return _dbContext.Orders.Include(u => u.ShippingMethod).Include(u => u.Discount)
                .Include(u => u.OrderItems).ThenInclude(u => u.Product)
                .ToList();
        }

        public Order GetOrderWithDetail(string userId, int orderId)
        {
            return _dbContext.Orders.Include(u => u.ShippingMethod).Include(u => u.Discount)
                .Include(u => u.OrderItems).ThenInclude(u => u.Product)
                .FirstOrDefault(u =>  u.Id == orderId);
        }

        public List<Order> GetAllOrdersWithDetail()
        {
            return _dbContext.Orders.Include(u => u.ShippingMethod).Include(u => u.Discount)
                .Include(u => u.OrderItems).ThenInclude(u => u.Product)
                .Include(u => u.User).ToList();
        }

        public Order AdminGetOrderWithDetail(int orderId)
        {
            return _dbContext.Orders.Include(u => u.ShippingMethod).Include(u => u.Discount)
                .Include(u => u.OrderItems).ThenInclude(u => u.Product)
                .Include(u => u.User).FirstOrDefault(u => u.Id == orderId);
        }
    }
}
