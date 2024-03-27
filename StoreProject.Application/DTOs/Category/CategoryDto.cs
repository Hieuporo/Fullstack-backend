using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.Category
{
    public class CategoryDto : BaseDto
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
	}
}
