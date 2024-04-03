using MediatR;
using StoreProject.Application.DTOs.Coupon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Discounts.Requests.GetDiscounts
{
    public class GetDiscountsQuery : IRequest<List<DiscountDto>>
    {
    }
}
