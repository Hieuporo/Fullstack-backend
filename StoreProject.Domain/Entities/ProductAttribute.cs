using StoreProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Domain.Entities
{
    public class ProductAttribute : BaseDomainEntity
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
