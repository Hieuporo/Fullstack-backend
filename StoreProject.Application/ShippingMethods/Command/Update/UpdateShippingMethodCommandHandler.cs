using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.Exceptions;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.ShippingMethods.Command.Update
{
    public class UpdateShippingMethodCommandHandler : IRequestHandler<UpdateShippingMethodCommand, int>
    {
        private readonly IShippingMethodRepository _shippingMethodRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateShippingMethodCommandHandler(IShippingMethodRepository shippingMethodRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _shippingMethodRepository = shippingMethodRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(UpdateShippingMethodCommand request, CancellationToken cancellationToken)
        {
            var shippingMethod = await _shippingMethodRepository.Get(request.Id) ?? throw new BadRequestException("ShippingMethod does not exist.");

            await _shippingMethodRepository.Update(_mapper.Map<ShippingMethod>(request));
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return request.Id;
        }
    }
}
