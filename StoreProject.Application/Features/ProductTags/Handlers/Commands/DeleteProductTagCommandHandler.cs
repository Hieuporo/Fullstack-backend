using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Application.Features.ProductTags.Requests.Commands;
using StoreProject.Application.Features.Coupons.Requests.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.ProductTags.Handlers.Commands
{
    public class DeleteProductTagCommandHandler : IRequestHandler<DeleteProductTagCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteProductTagCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteProductTagCommand request, CancellationToken cancellationToken)
        {

            var productTag = await _unitOfWork.ProductTagRepository.GetProductTag(request.ProductTagDto.ProductId , request.ProductTagDto.TagId);
            await _unitOfWork.ProductTagRepository.Delete(productTag);
            await _unitOfWork.Save();

            return Unit.Value;
        }
    }
}
