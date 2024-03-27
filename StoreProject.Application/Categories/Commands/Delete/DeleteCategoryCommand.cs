using MediatR;


namespace StoreProject.Application.Categories.Commands.Delete
{
    public class DeleteCategoryCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
