using MediatR;
using StoreProject.Application.DTOs.Coupon;


namespace StoreProject.Application.Discounts.Requests.GetDiscountByCode
{
    public class GetDiscountByCodeQuery : IRequest<DiscountDto>
    {
        public string DiscountCode { get; set; }
    }
}
