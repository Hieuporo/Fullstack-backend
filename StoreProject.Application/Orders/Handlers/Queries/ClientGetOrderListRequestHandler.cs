//using AutoMapper;
//using MediatR;
//using StoreProject.Application.DTOs.Order;
//using Microsoft.AspNetCore.Http;
//using StoreProject.Application.Orders.Requests.Queries;
//using StoreProject.Application.Contracts.IReposiotry;

//namespace StoreProject.Application.Orders.Handlers.Queries
//{
//    public class GetOrderListRequestHandler : IRequestHandler<ClientGetOrderListRequest, List<OrderClientDto>>
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        private readonly IMapper _mapper;
//        private readonly IHttpContextAccessor _httpContextAccessor;
//        public GetOrderListRequestHandler(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor)
//        {
//            _unitOfWork = unitOfWork;
//            _httpContextAccessor = httpContextAccessor;
//            _mapper = mapper;
//        }

//        public async Task<List<OrderClientDto>> Handle(ClientGetOrderListRequest request, CancellationToken cancellationToken)
//        {

//            //var userId = _httpContextAccessor.HttpContext.User.FindFirst(CustomClaimTypes.Uid).Value;

//            //var orders = _unitOfWork.OrderRepository.ClientGetAllOrdersWithDetail(userId);


//            //return _mapper.Map<List<OrderClientDto>>(orders);
//            throw new NotImplementedException();

//        }
//    }
//}
