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
    public class OrderRepository : GenericRepository<Order> , IOrderRepository
    {
         private readonly ApplicationDbContext _dbContext;
        public OrderRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Order> ClientGetAllOrdersWithDetail(string userId)
        {
                return _dbContext.Orders.Include(u => u.ShippingMethod).Include(u => u.Coupon)
                .Include(u => u.OrderItems).ThenInclude(u => u.ProductItem)
                .Where(u => u.UserId == userId).ToList();
        }

        public Order GetOrderWithDetail(string userId, int orderId)
        {
            return _dbContext.Orders.Include(u => u.ShippingMethod).Include(u => u.Coupon)
                .Include(u => u.OrderItems).ThenInclude(u => u.ProductItem)
                .FirstOrDefault(u => u.UserId == userId && u.Id == orderId);
        }

        public List<Order> GetAllOrdersWithDetail()
        {
            return _dbContext.Orders.Include(u => u.ShippingMethod).Include(u => u.Coupon)
                .Include(u => u.OrderItems).ThenInclude(u => u.ProductItem)
                .Include(u => u.User).ToList();
        }

        public Order AdminGetOrderWithDetail(int orderId)
        {
            return _dbContext.Orders.Include(u => u.ShippingMethod).Include(u => u.Coupon)
                .Include(u => u.OrderItems).ThenInclude(u => u.ProductItem)
                .Include(u => u.User).FirstOrDefault(u => u.Id == orderId);
        }
    }
}
