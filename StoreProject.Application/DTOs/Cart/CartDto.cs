

namespace StoreProject.Application.DTOs.Cart
{
    public class CartDto : BaseDto
    {
        public int UserId { get; set; }
        public ICollection<CartItemDto> CartItems { get; set; }
    }
}
