using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.DTOs.ShippingMethod;
using StoreProject.Application.Exceptions;
using StoreProject.Application.ShippingMethods.Queries.GetShippingMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.ShippingMethods.Queries.GetShippingMethods
{
    public class GetShippingMethodQueryHandler : IRequestHandler<GetShippingMethodQuery, ShippingMethodDto>
    {
        private readonly IShippingMethodRepository _shippingMethodRepository;
        private readonly IMapper _mapper;


        public GetShippingMethodQueryHandler(IShippingMethodRepository shippingMethodRepository, IMapper mapper)
        {
            _shippingMethodRepository = shippingMethodRepository;
            _mapper = mapper;
        }

        public async Task<ShippingMethodDto> Handle(GetShippingMethodQuery request, CancellationToken cancellationToken)
        {
          
                var shippingMethod= await _shippingMethodRepository.Get(request.Id);

                return shippingMethod == null
                    ? throw new BadRequestException("Shipping Method does not exist.")
                    : _mapper.Map<ShippingMethodDto>(shippingMethod);
        }
    }
}
