using MediatR;

namespace StoreProject.Application.Carts.Commands.MinusProduct
{
    public class MinusProductCommand : IRequest<Unit>
    {
        public int ProductId { get; set; }
    }
}
