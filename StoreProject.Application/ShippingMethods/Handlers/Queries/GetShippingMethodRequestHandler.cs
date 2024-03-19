using AutoMapper;
using MediatR;
using StoreProject.Application.DTOs.ShippingMethod;
using StoreProject.Application.DTOs.Coupon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreProject.Application.ShippingMethods.Requests.Queries;
using StoreProject.Application.Contracts.IReposiotry;

namespace StoreProject.Application.ShippingMethods.Handlers.Queries
{
    public class GetShippingMethodRequestHandler : IRequestHandler<GetShippingMethodRequest, ShippingMethodDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetShippingMethodRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ShippingMethodDto> Handle(GetShippingMethodRequest request, CancellationToken cancellationToken)
        {
            //var shippingMethod = await _unitOfWork.ShippingMethodRepository.Get(request.Id);
            //return _mapper.Map<ShippingMethodDto>(shippingMethod);

            throw new NotImplementedException();
        }
    }
}
