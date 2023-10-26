using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Application.Contracts.Infrastructure;
using StoreProject.Application.Features.Orders.Requests.Commands;
using Stripe;
using Stripe.Checkout;
using StoreProject.Application.Constants;

namespace StoreProject.Application.Features.Orders.Handlers.Commands
{
    public class ValidateStripeSessionCommandHandler : IRequestHandler<ValidateStripeSessionCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IEmailSender _emailSender;
        private readonly IMapper _mapper;
        private readonly string _stripeApiKey;
        public ValidateStripeSessionCommandHandler
        (
            IUnitOfWork unitOfWork, 
            IMapper mapper, 
            IEmailSender emailSender, 
            IHttpContextAccessor httpContextAccessor
        )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _emailSender = emailSender;
        }
        public async Task<Unit> Handle(ValidateStripeSessionCommand request, CancellationToken cancellationToken)
        {
            var order = await _unitOfWork.OrderRepository.Get(request.OrderId); ;

            var service = new SessionService();
            Session session = await service.GetAsync(order.StripeSessionId);

            if(session.PaymentIntentId != null)
            {
                var paymentIntentService = new PaymentIntentService();
                PaymentIntent paymentIntent = paymentIntentService.Get(session.PaymentIntentId);

                if (paymentIntent.Status == "succeeded")
                {
                    //then payment was successful
                    order.PaymentIntentId = paymentIntent.Id;
                    order.Status = OrderStatus.Status_Approved;
                    await _unitOfWork.Save();
                }
            }

            return Unit.Value;
        }
    }
}
