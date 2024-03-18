using MediatR;
using StoreProject.Application.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Products.Requests.Commands
{
    public class UpdateProductCommand : IRequest<Unit>
    {
        public UpdateProductDto ProductDto { get; set; }
    }
}
