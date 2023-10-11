using MediatR;
using StoreProject.Application.DTOs.Tag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.Tags.Requests.Commands
{
    public class UpdateTagCommand : IRequest<Unit>
    {
        public UpdateTagDto TagDto { get; set; }
    }
}
