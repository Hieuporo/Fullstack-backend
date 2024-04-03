using AutoMapper;
using MediatR;
using StoreProject.Application.Categories.Queries.GetCategoryById;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.DTOs.Category;
using StoreProject.Application.DTOs.Product;
using StoreProject.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Products.Queries.GetProduct
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductDto>
    {
        public readonly IProductRepository _productRepository;
        public readonly IMapper _mapper;

        public GetProductByIdQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<ProductDto> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.Get(request.Id);

            return product == null
                ? throw new BadRequestException("Product does not exist.")
                : _mapper.Map<ProductDto>(product);
        }
    }
}
