using AutoMapper;
using MediatR;
using StoreProject.Application.Brands.Requests.Queries;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.DTOs.Brand;
using StoreProject.Application.DTOs.Coupon;
using StoreProject.Application.Features.Coupons.Requests.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Brands.Handlers.Queries
{
    public class GetBrandListRequestHandler : IRequestHandler<GetBrandListRequest, List<BrandDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetBrandListRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<BrandDto>> Handle(GetBrandListRequest request, CancellationToken cancellationToken)
        {
            var brands = await _unitOfWork.BrandRepository.GetAll();
            return _mapper.Map<List<BrandDto>>(brands);
        }
    }
}
