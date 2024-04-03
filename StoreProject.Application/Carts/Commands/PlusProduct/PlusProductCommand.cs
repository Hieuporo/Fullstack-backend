using MediatR;


namespace StoreProject.Application.Carts.Commands.PlusProduct
{
    public class PlusProductCommand : IRequest<Unit>
    {
        public int ProductId { get; set; }
    }
}
