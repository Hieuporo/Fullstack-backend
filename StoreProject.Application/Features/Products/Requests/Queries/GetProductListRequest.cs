using MediatR;
using StoreProject.Application.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.Products.Requests.Queries
{
    public class GetProductListRequest : IRequest<List<ProductDto>>
    {
    }
}
