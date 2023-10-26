using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.Orders.Requests.Commands
{
    public class ValidateStripeSessionCommand : IRequest<Unit>
    {
        public int OrderId { get; set; }
    }
}
