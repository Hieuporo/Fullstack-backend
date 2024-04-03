using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.DTOs.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Categories.Queries.GetListCategory
{
    public class GetListCategoryQueryHandler : IRequestHandler<GetListCategoryQuery, List<CategoryDto>>
    {
        public readonly ICategoryRepository _categoryRepository;
        public readonly IMapper _mapper;

        public GetListCategoryQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<List<CategoryDto>> Handle(GetListCategoryQuery request, CancellationToken cancellationToken)
        {
            var categories = await _categoryRepository.GetAll();
            return _mapper.Map<List<CategoryDto>>(categories);
        }
    }
}
