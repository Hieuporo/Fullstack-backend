using MediatR;
using StoreProject.Application.DTOs.ProductTag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.ProductTags.Requests.Commands
{
    public class DeleteProductTagCommand : IRequest
    {
        public DeleteProductTagDto ProductTagDto { get; set; }

    }
}
