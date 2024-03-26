using StoreProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Domain.Entities
{
    public class UserDiscount : BaseDomainEntity
    {
        public int UserId { get; set; }
        public int DiscountId { get; set; }
        public User User { get; set; }
        public Discount Discount { get; set; }

    }
}
