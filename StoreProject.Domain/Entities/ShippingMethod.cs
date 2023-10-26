using StoreProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Domain.Entities
{
    public class ShippingMethod : BaseDomainEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ICollection<Order> Orders { get;}
    }
}
