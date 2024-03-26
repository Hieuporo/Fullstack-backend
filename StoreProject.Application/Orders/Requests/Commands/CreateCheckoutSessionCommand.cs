using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Orders.Requests.Commands
{
    public class CreateCheckoutSessionCommand : IRequest<string>
    {
        public int OrderId { get; set; }
    }
}
