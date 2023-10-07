using StoreProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Domain.Entities
{
    public class Category : BaseDomainEntity
    {
        public string Name {  get ; set; }
        public string Description {  get ; set; }
        public string ImageUrl {  get ; set; }
        //public int? ParentId {  get ; set; }
        //public Category Parent { get; set; }
        //public ICollection<Category> SubCategories { get; set; }

        public ICollection<Product> Products { get; }


    }
}
