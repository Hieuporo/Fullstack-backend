using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.Coupon
{
    public class DiscountDto 
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal DiscountValue { get; set; }
        public int MinOrderValue { get; set; }
        public string DiscountCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
