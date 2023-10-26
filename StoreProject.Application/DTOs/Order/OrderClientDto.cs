using StoreProject.Application.DTOs.Common;
using StoreProject.Application.DTOs.Coupon;
using StoreProject.Application.DTOs.ShippingMethod;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.Order
{
    public class OrderClientDto : BaseDto
    {
        public string UserId { get; set; }
        public int ShippingMethodId { get; set; }
        public ShippingMethodDto ShippingMethod { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Discount { get; set; }
        public decimal OrderTotal { get; set; }
        public string Status { get; set; }
    }
}
