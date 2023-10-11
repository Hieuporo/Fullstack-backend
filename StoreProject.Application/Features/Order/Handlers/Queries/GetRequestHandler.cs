//using AutoMapper;
//using MediatR;
//using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
//using StoreProject.Application.DTOs.Hold;
//using StoreProject.Application.DTOs.Coupon;
//using StoreProject.Application.Features.Holds.Requests.Queries;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace StoreProject.Application.Features.Order.Handlers.Queries
//{
//        public class GetHoldRequestHandler : IRequestHandler<GetHoldRequest, HoldDto>
//        {
//            private readonly IUnitOfWork _unitOfWork;
//            private readonly IMapper _mapper;

//            public GetHoldRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
//            {
//                _unitOfWork = unitOfWork;
//                _mapper = mapper;
//            }

//            public async Task<HoldDto> Handle(GetHoldRequest request, CancellationToken cancellationToken)
//            {
//                var hold = await _unitOfWork.HoldRepository.Get(request.Id);
//                return _mapper.Map<HoldDto>(hold);
//            }
//        }
//    }
