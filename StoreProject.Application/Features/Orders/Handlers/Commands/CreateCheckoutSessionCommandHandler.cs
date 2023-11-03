using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using StoreProject.Application.Constants;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Application.Exceptions;
using StoreProject.Application.Features.Orders.Requests.Commands;
using StoreProject.Domain.Entities;
using Stripe;
using Stripe.Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.Orders.Handlers.Commands
{
    public class CreateCheckoutSessionCommandHandler : IRequestHandler<CreateCheckoutSessionCommand, string>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CreateCheckoutSessionCommandHandler(
            IUnitOfWork unitOfWork, 
            IHttpContextAccessor httpContextAccessor
            )
        {

            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<string> Handle(CreateCheckoutSessionCommand request, CancellationToken cancellationToken)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(CustomClaimTypes.Uid).Value;

            var order = _unitOfWork.OrderRepository.GetOrderWithDetail(userId, request.OrderId);

            if (order == null)
            {
                throw new BadRequestException("Order is not exist");
            }

            var options = new SessionCreateOptions
            {
                SuccessUrl = request.StripeSetupDto.ApprovedUrl,
                CancelUrl = request.StripeSetupDto.CancelUrl,
                LineItems = new List<SessionLineItemOptions>(),
                Mode = "payment",
            };


            if (order.CouponId != 0 && order.CouponId != null )
            {
                var coupon = await _unitOfWork.CouponRepository.Get(order.CouponId.GetValueOrDefault());

                if(coupon == null)
                {
                    throw new BadRequestException("Something went wrong");
                }

                var DiscountsObj = new List<SessionDiscountOptions>()
                {
                    new SessionDiscountOptions
                    {
                        Coupon = coupon.CouponCode
                    }
                };

                options.Discounts = DiscountsObj;
            }

            var ShippingsObj = new List<SessionShippingOptionOptions>()
                {
                    new SessionShippingOptionOptions
                    {
                        ShippingRateData = new SessionShippingOptionShippingRateDataOptions
                        {
                            Type = "fixed_amount",
                            FixedAmount = new SessionShippingOptionShippingRateDataFixedAmountOptions
                            {
                                Amount = (long)(order.ShippingMethod.Price * 100),
                                Currency = "usd",
                            },
                            DisplayName = order.ShippingMethod.Name,
                            DeliveryEstimate = new SessionShippingOptionShippingRateDataDeliveryEstimateOptions
                            {
                                Minimum = new SessionShippingOptionShippingRateDataDeliveryEstimateMinimumOptions
                                {
                                    Unit = "business_day",
                                    Value = 5,
                                },
                                Maximum = new SessionShippingOptionShippingRateDataDeliveryEstimateMaximumOptions
                                {
                                    Unit = "business_day",
                                    Value = 7,
                                },
                            },
                        },
                    },
                };

            options.ShippingOptions = ShippingsObj;

            var listOrderItems = new List<OrderItem>();

            foreach (var orderItem in order.OrderItems)
            {

                var sessionLineItem = new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmount = (long)(orderItem.ProductItem.Price * 100),
                        Currency = "usd",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = orderItem.ProductItem.Name
                        }
                    },
                    Quantity = orderItem.Quantity
                };

                options.LineItems.Add(sessionLineItem);

                listOrderItems.Add(new OrderItem
                {
                    OrderId = order.Id,
                    ProductItemId = orderItem.ProductItemId,
                    Quantity = orderItem.Quantity
                });
            }


            var service = new SessionService();
            Session session = service.Create(options);
            order.StripeSessionId = session.Id;

            await _unitOfWork.Save();

            return session.Url;
        }
    }
}
