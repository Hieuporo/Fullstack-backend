﻿using StoreProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Domain.Entities
{
    public class ProductTag : BaseDomainEntity
    {
        public int TagId {  get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public Tag Tag { get; set; } = null!;
    }
}
