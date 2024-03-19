using MediatR;
using StoreProject.Application.DTOs.ShippingMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.ShippingMethods.Requests.Commands
{
    public class CreateShippingMethodCommand : IRequest<int>
    {
        public CreateShippingMethodDto ShippingMethodDto { get; set; }
    }
}
