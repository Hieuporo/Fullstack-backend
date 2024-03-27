using MediatR;


namespace StoreProject.Application.Categories.Commands.Update
{
    public class UpdateCategoryCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

    }
}
