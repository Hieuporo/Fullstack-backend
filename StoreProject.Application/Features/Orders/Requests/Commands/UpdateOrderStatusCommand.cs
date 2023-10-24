using MediatR;
using StoreProject.Application.DTOs.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.Orders.Requests.Commands
{
    public class UpdateOrderStatusCommand : IRequest<Unit>
    {
        public UpdateOrderStatusDto OrderDto { get; set; }
    }
}
