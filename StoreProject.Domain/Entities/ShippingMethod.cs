using StoreProject.Domain.Common;

namespace StoreProject.Domain.Entities
{
    public class ShippingMethod : BaseDomainEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ICollection<Order> Orders { get;}
    }
}
