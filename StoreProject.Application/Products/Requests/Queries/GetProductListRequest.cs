using MediatR;
using StoreProject.Application.DTOs.Product;
using StoreProject.Application.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Products.Requests.Queries
{
    public class GetProductListRequest : IRequest<PagedResult>
    {
        public int? CategoryId { get; set; }
        public string? SearchTerm { get; set; }
        public string? SortName { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
