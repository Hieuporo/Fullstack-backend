using MediatR;
using StoreProject.Application.DTOs.Category;


namespace StoreProject.Application.Categories.Queries.GetListCategory
{
    public class GetListCategoryQuery : IRequest<List<CategoryDto>>
    {
    }
}
