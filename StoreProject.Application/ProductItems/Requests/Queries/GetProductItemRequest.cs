using MediatR;
using StoreProject.Application.DTOs.ProductItem;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.ProductItems.Requests.Queries
{
    public class GetProductItemRequest : IRequest<ProductItemDto>
    {
        public int Id { get; set; }
    }
}
