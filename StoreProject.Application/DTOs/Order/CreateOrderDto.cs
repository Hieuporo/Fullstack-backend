using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.Order
{
    public class CreateOrderDto 
    {
        public string UserId { get; set; }
        public int? CouponId { get; set; }
        public int ShippingMethodId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public double Discount { get; set; }
        public double OrderTotal { get; set; }
        public string Status { get; set; }
        public string PaymentIntentId { get; set; }
        public string StripeSessionId { get; set; }
    }
}
