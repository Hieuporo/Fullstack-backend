using MediatR;


namespace StoreProject.Application.ShippingMethods.Command.Create
{
    public class CreateShippingMethodCommand : IRequest<int>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

    }
}
