using AutoMapper;
using MediatR;
using StoreProject.Application.CartItems.Requests.Queries;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.DTOs.CartItem;


namespace StoreProject.Application.CartItems.Handlers.Queries
{
    public class GetCartItemListRequestHandler : IRequestHandler<GetCartItemListRequest, List<CartItemDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetCartItemListRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<CartItemDto>> Handle(GetCartItemListRequest request, CancellationToken cancellationToken)
        {
            //var cartItems = await _unitOfWork.CartItemRepository.GetAll();
            //return _mapper.Map<List<CartItemDto>>(cartItems);



            throw new NotImplementedException();
        }
    }
}
