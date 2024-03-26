using MediatR;
using StoreProject.Application.DTOs.Coupon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Coupons.Requests.Queries
{
    public class GetCouponListRequest : IRequest<List<DiscountDto>>
    {

    }
}
