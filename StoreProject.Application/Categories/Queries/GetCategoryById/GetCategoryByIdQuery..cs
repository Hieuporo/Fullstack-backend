using MediatR;
using StoreProject.Application.DTOs.Category;


namespace StoreProject.Application.Categories.Queries.GetCategoryById
{
    public class GetCategoryByIdQuery : IRequest<CategoryDto>
    {
        public int Id { get; set; }
    }
}
