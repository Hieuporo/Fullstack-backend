using MediatR;
using StoreProject.Application.DTOs.Brand;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Brands.Requests.Queries
{
    public class GetBrandListRequest : IRequest<List<BrandDto>>
    {
    }
}
