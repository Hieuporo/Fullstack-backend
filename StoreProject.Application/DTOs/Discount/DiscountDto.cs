using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.Coupon
{
    public class DiscountDto 
    {
        public string CouponCode { get; set; }
        public decimal MinAmount { get; set; }
        public decimal DiscountAmount { get; set; }
    }
}
