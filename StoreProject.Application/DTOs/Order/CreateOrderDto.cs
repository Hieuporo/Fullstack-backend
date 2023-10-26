using StoreProject.Application.DTOs.CartItem;
using StoreProject.Application.DTOs.OrderItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.Order
{
    public class CreateOrderDto 
    {
        public int CouponId { get; set; }
        public int ShippingMethodId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public IList<int> CartItemIdList { get; set; }

    }
}
