using MediatR;


namespace StoreProject.Application.ShippingMethods.Command.Update
{
    public class UpdateShippingMethodCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public decimal Price { get; set;}
    }
}
