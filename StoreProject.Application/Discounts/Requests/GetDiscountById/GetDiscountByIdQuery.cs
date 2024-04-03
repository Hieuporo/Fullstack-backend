using MediatR;
using StoreProject.Application.DTOs.Coupon;

namespace StoreProject.Application.Discounts.Requests.GetDiscountById
{
    public class GetDiscountByIdQuery : IRequest<DiscountDto>
    {
        public int Id { get; set; }
    }
}
