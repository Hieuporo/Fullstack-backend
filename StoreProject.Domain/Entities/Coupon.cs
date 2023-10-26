using StoreProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Domain.Entities
{
    public class Coupon : BaseDomainEntity
    {

        public string CouponCode { get; set; }
        public decimal MinAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public ICollection<Order> Orders { get; }

    }
}
