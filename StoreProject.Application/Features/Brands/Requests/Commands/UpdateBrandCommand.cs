using MediatR;
using StoreProject.Application.DTOs.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.Brands.Requests.Commands
{
    public class UpdateBrandCommand : IRequest<Unit>
    {
        public UpdateBrandDto BrandDto { get; set; }
    }
}
