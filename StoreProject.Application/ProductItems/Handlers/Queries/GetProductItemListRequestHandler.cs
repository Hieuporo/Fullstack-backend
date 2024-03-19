using AutoMapper;
using MediatR;
using StoreProject.Application.DTOs.ProductItem;
using StoreProject.Application.ProductItems.Requests.Queries;
using StoreProject.Application.Contracts.IReposiotry;

namespace StoreProject.Application.ProductItems.Handlers.Queries
{
    public class GetProductItemListRequestHandler : IRequestHandler<GetProductItemListRequest, List<ProductItemDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetProductItemListRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<ProductItemDto>> Handle(GetProductItemListRequest request, CancellationToken cancellationToken)
        {
            //var productItems = await _unitOfWork.ProductItemRepository.GetAll();

            //return _mapper.Map<List<ProductItemDto>>(productItems);
            throw new NotImplementedException();

        }
    }
}
