using MediatR;
using StoreProject.Application.DTOs.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.Categories.Requests.Commands
{
    public class UpdateCategoryCommand : IRequest<Unit>
    {
        public UpdateCategoryDto CategoryDto { get; set; }
    }
}
