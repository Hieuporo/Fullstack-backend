using StoreProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Domain.Entities
{
    public class Tag : BaseDomainEntity
    {
        public string Name { get; set; }
        public List<ProductTag> ProductTags  { get; }

    }
}
