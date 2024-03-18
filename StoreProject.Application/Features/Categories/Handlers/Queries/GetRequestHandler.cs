using AutoMapper;
using MediatR;
using StoreProject.Application.Categories.Requests.Queries;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.DTOs.Category;
using StoreProject.Application.DTOs.Coupon;
using StoreProject.Application.Features.Coupons.Requests.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Categories.Handlers.Queries
{
    public class GetCategoryListRequestHandler : IRequestHandler<GetCategoryListRequest, List<CategoryDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetCategoryListRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<CategoryDto>> Handle(GetCategoryListRequest request, CancellationToken cancellationToken)
        {
            var categorys = await _unitOfWork.CategoryRepository.GetAll();
            return _mapper.Map<List<CategoryDto>>(categorys);
        }
    }
}
