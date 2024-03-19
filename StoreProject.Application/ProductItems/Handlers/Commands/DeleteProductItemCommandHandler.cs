using AutoMapper;
using StoreProject.Application.ProductItems.Requests.Commands;
using StoreProject.Application.Contracts.IReposiotry;
using MediatR;

namespace StoreProject.Application.ProductItems.Handlers.Commands
{
    public class DeleteProductItemCommandHandler : IRequestHandler<DeleteProductItemCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteProductItemCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteProductItemCommand request, CancellationToken cancellationToken)
        {

            //var productItem = await _unitOfWork.ProductItemRepository.Get(request.Id);



            //await _unitOfWork.ProductItemRepository.Delete(productItem);
            //await _unitOfWork.Save();

            return Unit.Value;
        }
    }
}
