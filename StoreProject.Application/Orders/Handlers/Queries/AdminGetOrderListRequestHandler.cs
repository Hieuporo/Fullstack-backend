//using AutoMapper;
//using MediatR;
//using StoreProject.Application.DTOs.Order;
//using Microsoft.AspNetCore.Http;
//using StoreProject.Application.Orders.Requests.Queries;
//using StoreProject.Application.Contracts.IReposiotry;

//namespace StoreProject.Application.Orders.Handlers.Queries
//{
//    public class AdminGetOrderListRequestHandler : IRequestHandler<AdminGetOrderListRequest, List<OrderDto>>
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        private readonly IMapper _mapper;
//        private readonly IHttpContextAccessor _httpContextAccessor;
//        public AdminGetOrderListRequestHandler(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor)
//        {
//            _unitOfWork = unitOfWork;
//            _httpContextAccessor = httpContextAccessor;
//            _mapper = mapper;
//        }


//        public async Task<List<OrderDto>> Handle(AdminGetOrderListRequest request, CancellationToken cancellationToken)
//        {
//            //var userId = _httpContextAccessor.HttpContext.User.FindFirst(CustomClaimTypes.Uid).Value;

//            //var orders = _unitOfWork.OrderRepository.GetAllOrdersWithDetail();


//            //return _mapper.Map<List<OrderDto>>(orders);
//            throw new NotImplementedException();

//        }
//    }
//}
