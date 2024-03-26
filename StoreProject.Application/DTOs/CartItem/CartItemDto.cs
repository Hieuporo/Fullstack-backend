using StoreProject.Application.DTOs.Product;


namespace StoreProject.Application.DTOs.CartItem
{
    public class CartItemDto : BaseDto
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public ProductDto Product { get; set; }
        public int Quantity { get; set; }
    }
}
