using StoreProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Domain.Entities
{
    public class OrderItem : BaseDomainEntity
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
}
