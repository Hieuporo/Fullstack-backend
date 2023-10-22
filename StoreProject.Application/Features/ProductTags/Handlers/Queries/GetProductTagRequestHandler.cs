using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Application.DTOs.ProductTag;
using StoreProject.Application.DTOs.Coupon;
using StoreProject.Application.Features.ProductTags.Requests.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.Order.Handlers.Queries
{
    public class GetProductTagRequestHandler : IRequestHandler<GetProductTagRequest, ProductTagDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetProductTagRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ProductTagDto> Handle(GetProductTagRequest request, CancellationToken cancellationToken)
        {
            var hold = await _unitOfWork.ProductTagRepository.Get(request.Id);
            return _mapper.Map<ProductTagDto>(hold);
        }
    }
}
