using StoreProject.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;


namespace StoreProject.Domain.Entities
{
    public class Product : BaseDomainEntity
    {
        public string Name {  get; set; }
        public string? Description { get; set; }
        public string? Slug { get; set; }
        public int ViewCount { get; set; }
        public string Image {  get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal BaseCost { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal DiscountCost { get; set; }
        public int Quantity { get; set; }
        public string Brand { get; set; }
        public ICollection<ProductAttribute>? ProductAttributes { get; set; }
        public ICollection<FavoriteProduct>? FavoriteProducts { get; set; }
    }
}
