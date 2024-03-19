//using AutoMapper;
//using MediatR;
//using StoreProject.Application.DTOs.Order;
//using StoreProject.Application.Exceptions;
//using StoreProject.Application.Orders.Requests.Queries;
//using StoreProject.Application.Contracts.IReposiotry;

//namespace StoreProject.Application.Orders.Handlers.Queries
//{
//    public class AdminGetOrderRequestHandler : IRequestHandler<AdminGetOrderRequest, OrderDto>
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        private readonly IMapper _mapper;
//        public AdminGetOrderRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
//        {
//            _unitOfWork = unitOfWork;
//            _mapper = mapper;
//        }

//        public async Task<OrderDto> Handle(AdminGetOrderRequest request, CancellationToken cancellationToken)
//        {
//            //var order = _unitOfWork.OrderRepository.AdminGetOrderWithDetail(request.Id);

//            //if (order == null)
//            //{
//            //    throw new BadRequestException("Order is not exist");
//            //}

//            //return _mapper.Map<OrderDto>(order);
//            throw new NotImplementedException();

//        }
//    }
//}
