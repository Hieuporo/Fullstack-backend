using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.ShippingMethods.Requests.Commands
{
    public class DeleteShippingMethodCommand : IRequest
    {
        public int Id { get; set; }
    }
}
