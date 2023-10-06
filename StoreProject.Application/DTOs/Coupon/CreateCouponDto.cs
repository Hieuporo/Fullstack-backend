using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.Coupon
{
    public class CreateCouponDto
    {
        public string CouponCode { get; set; }
        public double MinAmount { get; set; }
        public double DiscountAmount { get; set; }
    }
}
