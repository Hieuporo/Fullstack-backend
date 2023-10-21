using MediatR;
using StoreProject.Application.DTOs.CartItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.CartItems.Requests.Commands
{
    public class CreateCartItemCommand : IRequest<int>
    {
        public CreateCartItemDto CartItemDto { get; set; }
    }
}
