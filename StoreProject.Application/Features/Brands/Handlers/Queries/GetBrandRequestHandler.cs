using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Application.DTOs.Brand;
using StoreProject.Application.DTOs.Coupon;
using StoreProject.Application.Features.Brands.Requests.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.Brands.Handlers.Queries
{
    public class GetListProductRequestHandler
    {
        public class GetBrandRequestHandler : IRequestHandler<GetBrandRequest, BrandDto>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;

            public GetBrandRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }

            public async Task<BrandDto> Handle(GetBrandRequest request, CancellationToken cancellationToken)
            {
                var brand = await _unitOfWork.BrandRepository.Get(request.Id);
                return _mapper.Map<BrandDto>(brand);
            }
        }
    }
}