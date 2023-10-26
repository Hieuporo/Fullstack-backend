using StoreProject.Application.DTOs.Common;
using StoreProject.Application.DTOs.ProductItem;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.OrderItem
{
    public class OrderItemDto : BaseDto
    {
        public int OrderId { get; set; }
        public ProductItemDto ProductItem { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
