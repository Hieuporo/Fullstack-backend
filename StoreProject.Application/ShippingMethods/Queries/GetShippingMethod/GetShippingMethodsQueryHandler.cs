using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.DTOs.ShippingMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.ShippingMethods.Queries.GetShippingMethod
{
    public class GetShippingMethodsQueryHandler : IRequestHandler<GetShippingMethodsQuery, List<ShippingMethodDto>>
    {
        private readonly IShippingMethodRepository _shippingMethodRepository;
        private readonly IMapper _mapper;


        public GetShippingMethodsQueryHandler(IShippingMethodRepository shippingMethodRepository, IMapper mapper)
        {
            _shippingMethodRepository = shippingMethodRepository;
            _mapper = mapper;
        }

        public async Task<List<ShippingMethodDto>> Handle(GetShippingMethodsQuery request, CancellationToken cancellationToken)
        {
            var shippingMethods = await _shippingMethodRepository.GetAll();
            return _mapper.Map<List<ShippingMethodDto>>(shippingMethods);
        }
    }
}
