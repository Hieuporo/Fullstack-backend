using StoreProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Domain.Entities
{
    public class Order : BaseDomainEntity
    {
        public string UserId {  get; set; }
        public string? CouponId { get; set; }
        public string ShippingMethodId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public double Discount { get; set; }
        public double OrderTotal { get; set; }
        public string Status { get; set; }
        public string PaymentIntentId { get; set; }
        public string StripeSessionId { get; set;}

    }
}
