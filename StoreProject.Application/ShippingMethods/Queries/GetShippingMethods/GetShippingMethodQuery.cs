using MediatR;
using StoreProject.Application.DTOs.ShippingMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.ShippingMethods.Queries.GetShippingMethods
{
    public class GetShippingMethodQuery : IRequest<ShippingMethodDto>
    {
        public int Id { get; set; }
    }
}
