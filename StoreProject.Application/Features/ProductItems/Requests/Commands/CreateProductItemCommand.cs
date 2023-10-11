using MediatR;
using StoreProject.Application.DTOs.ProductItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.ProductItems.Requests.Commands
{
    public class CreateProductItemCommand : IRequest<int>
    {
        public CreateProductItemDto ProductItemDto { get; set; }
    }
}
