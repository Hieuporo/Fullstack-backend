using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.Brands.Requests.Commands
{
    public class DeleteBrandCommand : IRequest
    {
        public int Id { get; set; }
    }
}
