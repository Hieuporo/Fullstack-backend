using StoreProject.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.Brand
{
    public class UpdateBrandDto : BaseDto
    {
        public string Name { get; set; }
    }
}
