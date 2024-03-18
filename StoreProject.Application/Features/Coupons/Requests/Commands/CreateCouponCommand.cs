using MediatR;
using StoreProject.Application.DTOs.Coupon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Coupons.Requests.Commands
{
    public class CreateCouponCommand : IRequest<int>
    {
        public CreateCouponDto CouponDto { get; set; }
    }
}
