using StoreProject.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.DTOs.Order
{
    public class UpdateOrderStatusDto : BaseDto
    {
        public string UserId { get; set; }
        public string Status { get; set; }
        public string PaymentIntentId { get; set; }
        public string StripeSessionId { get; set; }
    }
}
