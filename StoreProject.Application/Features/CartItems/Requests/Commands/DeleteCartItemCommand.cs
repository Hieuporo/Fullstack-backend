using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.CartItems.Requests.Commands
{
    public class DeleteCartItemCommand : IRequest
    {
        public int Id { get; set; }
    }
}
