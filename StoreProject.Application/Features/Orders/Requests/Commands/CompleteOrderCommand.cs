using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.Orders.Requests.Commands
{
    public class CompleteOrderCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
