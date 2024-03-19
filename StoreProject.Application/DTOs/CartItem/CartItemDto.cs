﻿using StoreProject.Application.DTOs.ProductItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.CartItem
{
    public class CartItemDto : BaseDto
    {
        public int CartId { get; set; }
        public int ProductItemId { get; set; }
        public ProductItemDto ProductItem{ get; set; }
        public int Quantity { get; set; }
    }
}
