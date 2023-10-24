using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Application.DTOs.Product;
using StoreProject.Application.DTOs.ProductItem;
using StoreProject.Application.Features.Products.Requests.Queries;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.Products.Handlers.Queries
{
  
        public class GetListProductRequestHandler : IRequestHandler<GetProductListRequest, List<ProductDto>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;

            public GetListProductRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }

            public async Task<List<ProductDto>> Handle(GetProductListRequest request, CancellationToken cancellationToken)
            {
                var products = _unitOfWork.ProductRepository.GetProductsWithProductItem();
            return _mapper.Map<List<ProductDto>>(products);
            }
        }
    }
