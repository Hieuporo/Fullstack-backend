using AutoMapper;
using MediatR;
using StoreProject.Application.Categories.Requests.Queries;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.DTOs.Category;
using StoreProject.Application.DTOs.Coupon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Categories.Handlers.Queries
{
    public class GetCategoryRequestHandler : IRequestHandler<GetCategoryRequest, CategoryDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetCategoryRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CategoryDto> Handle(GetCategoryRequest request, CancellationToken cancellationToken)
        {
            var category = await _unitOfWork.CategoryRepository.Get(request.Id);
            return _mapper.Map<CategoryDto>(category);
        }
    }
}
