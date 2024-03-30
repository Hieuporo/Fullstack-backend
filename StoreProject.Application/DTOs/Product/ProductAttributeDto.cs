using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.Product
{
    public class ProductAttributeDto : BaseDto
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
