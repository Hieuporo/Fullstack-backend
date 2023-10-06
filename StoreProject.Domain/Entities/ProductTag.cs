using StoreProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Domain.Entities
{
    public class ProductTag : BaseDomainEntity
    {
        public string TagId {  get; set; }
        public string ProductId { get; set; }

    }
}
