using MediatR;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreProject.Application.Products.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Image { get; set; }
        public decimal BaseCost { get; set; }
        public decimal DiscountCost { get; set; }
        public int Quantity { get; set; }
        public string Brand { get; set; }
        public int CategoryId { get; set; }
    }
}
