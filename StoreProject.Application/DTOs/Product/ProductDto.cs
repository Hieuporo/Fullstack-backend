
using StoreProject.Application.DTOs.Category;

namespace StoreProject.Application.DTOs.Product
{
    public class ProductDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public int CategoryId { get; set; }
        public int Quantity { get; set; }
        public CategoryDto Category { get; set; }
        public string Brand { get; set; }
        public string Image { get; set; }
    }
}
