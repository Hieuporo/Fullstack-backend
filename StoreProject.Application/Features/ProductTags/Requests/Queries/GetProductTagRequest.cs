using MediatR;
using StoreProject.Application.DTOs.ProductTag;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.ProductTags.Requests.Queries
{
    public class GetProductTagRequest : IRequest<ProductTagDto>
    {
        public int Id { get; set; }
    }
}
