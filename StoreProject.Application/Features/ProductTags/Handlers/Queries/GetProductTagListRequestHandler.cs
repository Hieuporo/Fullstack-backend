using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Application.DTOs.ProductTag;
using StoreProject.Application.DTOs.Coupon;
using StoreProject.Application.Features.ProductTags.Requests.Queries;
using StoreProject.Application.Features.Coupons.Requests.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.ProductTags.Handlers.Queries
{
    public class GetProductTagListRequestHandler : IRequestHandler<GetProductTagListRequest, List<ProductTagDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetProductTagListRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<ProductTagDto>> Handle(GetProductTagListRequest request, CancellationToken cancellationToken)
        {
            var holds = await _unitOfWork.ProductTagRepository.GetAll();
            return _mapper.Map<List<ProductTagDto>>(holds);
        }
    }
}
