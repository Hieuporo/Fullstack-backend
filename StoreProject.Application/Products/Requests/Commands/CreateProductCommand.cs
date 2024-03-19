using MediatR;
using StoreProject.Application.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Products.Requests.Commands
{
    public class CreateProductCommand : IRequest<int>
    {
        public CreateProductDto ProductDto { get; set; }
    }
}
