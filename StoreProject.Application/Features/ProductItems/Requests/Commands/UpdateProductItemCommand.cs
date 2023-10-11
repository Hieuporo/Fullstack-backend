using MediatR;
using StoreProject.Application.DTOs.ProductItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.ProductItems.Requests.Commands
{
    public class UpdateProductItemCommand : IRequest<Unit>
    {
        public UpdateProductItemDto ProductItemDto { get; set; }
    }
}
