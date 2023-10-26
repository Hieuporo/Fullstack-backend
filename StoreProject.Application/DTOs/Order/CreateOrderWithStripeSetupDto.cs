using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.Order
{
    public class CreateOrderWithStripeSetupDto
    {
        public CreateOrderDto CreateOrderDto { get; set; }
        public StripeSetupDto StripeSetupDto { get; set; }
    }
}
