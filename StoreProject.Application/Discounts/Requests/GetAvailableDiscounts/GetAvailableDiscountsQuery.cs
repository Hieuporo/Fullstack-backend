using MediatR;
using StoreProject.Application.DTOs.Coupon;
using StoreProject.Domain.Entities;


namespace StoreProject.Application.Discounts.Requests.GetAvailableDiscounts
{
    public class GetAvailableDiscountsQuery : IRequest<List<DiscountDto>>
    {
    }
}
