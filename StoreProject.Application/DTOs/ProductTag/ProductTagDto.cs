using StoreProject.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.ProductTag
{
    public class ProductTagDto : BaseDto
    {
        public int TagId { get; set; }
        public int ProductId { get; set; }
    }
}
