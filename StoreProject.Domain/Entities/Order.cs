using StoreProject.Domain.Common;
using StoreProject.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Domain.Entities
{
    public class Order : BaseDomainEntity
    {
        public int UserId {  get; set; }
        public User User { get; set; }
        public int ShippingMethodId { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Discount { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal OrderTotal { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime? PaymentAt { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }

    }
}
