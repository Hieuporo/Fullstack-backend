using StoreProject.Application.DTOs.Product;

namespace StoreProject.Application.DTOs.OrderItem
{
    public class OrderItemDto : BaseDto
    {
        public int OrderId { get; set; }
        public int Price { get; set; }
        public ProductDto Product { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
