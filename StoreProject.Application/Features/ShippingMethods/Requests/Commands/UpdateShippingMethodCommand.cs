using MediatR;
using StoreProject.Application.DTOs.ShippingMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.ShippingMethods.Requests.Commands
{
    public class UpdateShippingMethodCommand : IRequest<Unit>
    {
        public UpdateShippingMethodDto ShippingMethodDto { get; set; }
    }
}
