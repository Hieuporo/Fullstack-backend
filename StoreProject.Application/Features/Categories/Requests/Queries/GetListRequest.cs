using MediatR;
using StoreProject.Application.DTOs.Category;

using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.Categories.Requests.Queries
{
    public class GetCategoryListRequest : IRequest<List<CategoryDto>>
    {
    }
}
