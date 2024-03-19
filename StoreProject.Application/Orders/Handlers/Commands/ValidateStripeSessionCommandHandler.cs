//using AutoMapper;
//using MediatR;
//using Microsoft.AspNetCore.Http;
//using StoreProject.Application.Orders.Requests.Commands;
//using StoreProject.Application.Contracts.IReposiotry;
//using StoreProject.Application.Contracts.Service;

//namespace StoreProject.Application.Orders.Handlers.Commands
//{
//    public class ValidateStripeSessionCommandHandler : IRequestHandler<ValidateStripeSessionCommand>
//    {

//        public ValidateStripeSessionCommandHandler
//        (
//            IUnitOfWork unitOfWork,
//            IMapper mapper,
//            IEmailSender emailSender,
//            IHttpContextAccessor httpContextAccessor
//        )
//        {
//            _unitOfWork = unitOfWork;
//            _mapper = mapper;
//            _httpContextAccessor = httpContextAccessor;
//            _emailSender = emailSender;
//        }
//        public async Task<Unit> Handle(ValidateStripeSessionCommand request, CancellationToken cancellationToken)
//        {
//            var order = await _unitOfWork.OrderRepository.Get(request.OrderId); ;

//            var service = new SessionService();
//            Session session = await service.GetAsync(order.StripeSessionId);

//            if (session.PaymentIntentId != null)
//            {
//                var paymentIntentService = new PaymentIntentService();
//                PaymentIntent paymentIntent = paymentIntentService.Get(session.PaymentIntentId);

//                if (paymentIntent.Status == "succeeded")
//                {
//                    then payment was successful
//                    order.PaymentIntentId = paymentIntent.Id;
//                    order.Status = OrderStatus.Status_Approved;
//                    await _unitOfWork.Save();
//                }
//            }

//            return Unit.Value;
//        }
//    }
//}
