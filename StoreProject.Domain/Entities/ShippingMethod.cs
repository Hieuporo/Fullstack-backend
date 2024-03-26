using StoreProject.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreProject.Domain.Entities
{
    public class ShippingMethod : BaseDomainEntity
    {
        public string Name { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public ICollection<Order> Orders { get;}
    }
}
