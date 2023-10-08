using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.ProductItem
{
    public class CreateProductItemDto 
    {
        public int ProductId { get; set; }
        public int QuantityInStock { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
    }
}
