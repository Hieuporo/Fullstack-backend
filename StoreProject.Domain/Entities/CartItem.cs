﻿using StoreProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Domain.Entities
{
    public class CartItem : BaseDomainEntity
    {
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get ; set; }
        public double Price { get; set; }
    }
}
