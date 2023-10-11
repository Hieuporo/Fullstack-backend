using MediatR;
using StoreProject.Application.DTOs.ShippingMethod;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.ShippingMethods.Requests.Queries
{
    public class GetShippingMethodRequest : IRequest<ShippingMethodDto>
    {
        public int Id { get; set; }
    }
}
