using StoreProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Domain.Entities
{
    public class ProductItem : BaseDomainEntity
    {
        public string ProductId { get; set; }
        public int QuantityInStock { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }

    }
}
