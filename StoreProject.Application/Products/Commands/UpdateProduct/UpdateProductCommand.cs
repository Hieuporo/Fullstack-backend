using MediatR;


namespace StoreProject.Application.Products.Commands.UpdateProduct
{
    public class UpdateProductCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Image { get; set; }
        public decimal BaseCost { get; set; }
        public decimal? DiscountCost { get; set; }
        public int Quantity { get; set; }
        public string Brand { get; set; }
        public int CategoryId { get; set; }
    }
}
