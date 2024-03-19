using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Brands.Commands.CreateBrand
{
    public class CreateBrandCommand : IRequest<int>
    {
        public string Name { get; set; }
    }
}
