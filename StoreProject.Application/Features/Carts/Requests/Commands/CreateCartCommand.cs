using MediatR;
using StoreProject.Application.DTOs.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.Carts.Requests.Commands
{
    public class CreateCartCommand : IRequest<int>
    {
        public string UserId { get; set; }
    }
}
