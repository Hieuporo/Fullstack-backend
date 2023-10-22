using StoreProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Domain.Entities
{
    public class CartItem : BaseDomainEntity
    {
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        public int ProductItemId { get; set; }
        public ProductItem ProductItem { get; set; }
        public int Quantity { get ; set; }
        public double Price { get; set; }
    }
}
