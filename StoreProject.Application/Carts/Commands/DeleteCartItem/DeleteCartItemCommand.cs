using Amazon.Runtime.Internal;
using MediatR;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Carts.Commands.DeleteCartItem
{
    public class DeleteCartItemCommand : IRequest<Unit>
    {
        public int CartItemId { get; set; }
    }
}
