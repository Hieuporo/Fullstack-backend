using MediatR;
using StoreProject.Application.DTOs.Order;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Orders.Requests.Queries
{
    public class AdminGetOrderListRequest : IRequest<List<OrderDto>>
    {

    }
}
