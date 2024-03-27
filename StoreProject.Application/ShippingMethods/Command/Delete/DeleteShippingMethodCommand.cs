using MediatR;


namespace StoreProject.Application.ShippingMethods.Command.Delete
{
    public class DeleteShippingMethodCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
