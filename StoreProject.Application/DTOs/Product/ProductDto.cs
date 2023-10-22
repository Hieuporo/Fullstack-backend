using StoreProject.Application.DTOs.Common;
using StoreProject.Application.DTOs.ProductItem;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.Product
{
    public class ProductDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<ProductItemDto> ProductItems { get; }
    }
}
