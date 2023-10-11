using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.Carts.Requests.Commands
{
    public class DeleteCartCommand : IRequest
    {
        public int Id { get; set; }
    }
}
