using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.Tags.Requests.Commands
{
    public class DeleteTagCommand : IRequest
    {
        public int Id { get; set; }
    }
}
