using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Contracts.Infrastructure.IReposiotry
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        List<Order> ClientGetAllOrdersWithDetail(string userId);
        List<Order> GetAllOrdersWithDetail();
        Order GetOrderWithDetail(string userId, int orderId);
        Order AdminGetOrderWithDetail(int orderId);

    }
}
