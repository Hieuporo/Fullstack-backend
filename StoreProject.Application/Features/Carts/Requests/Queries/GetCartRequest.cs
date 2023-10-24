using MediatR;
using StoreProject.Application.DTOs.Cart;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.Carts.Requests.Queries
{
    public class GetCartRequest : IRequest<CartDto>
    {
    }
}
