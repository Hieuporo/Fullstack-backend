//using AutoMapper;
//using MediatR;
//using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
//using StoreProject.Application.DTOs.Hold;
//using StoreProject.Application.DTOs.Coupon;
//using StoreProject.Application.Features.Holds.Requests.Queries;
//using StoreProject.Application.Features.Coupons.Requests.Queries;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace StoreProject.Application.Features.Holds.Handlers.Queries
//{
//    public class GetHoldListRequestHandler : IRequestHandler<GetHoldListRequest, List<HoldDto>>
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        private readonly IMapper _mapper;

//        public GetHoldListRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
//        {
//            _unitOfWork = unitOfWork;
//            _mapper = mapper;
//        }

//        public async Task<List<HoldDto>> Handle(GetHoldListRequest request, CancellationToken cancellationToken)
//        {
//            var holds = await _unitOfWork.HoldRepository.GetAll();
//            return _mapper.Map<List<HoldDto>>(holds);
//        }
//    }
//}
