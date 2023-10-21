using MediatR;
using StoreProject.Application.DTOs.CartItem;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.CartItems.Requests.Queries
{
    public class GetCartItemListRequest : IRequest<List<CartItemDto>>
    {
    }
}
