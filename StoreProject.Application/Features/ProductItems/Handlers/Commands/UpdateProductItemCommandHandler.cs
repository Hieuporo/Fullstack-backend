﻿using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.DTOs.ProductItem.Validators;
using StoreProject.Application.Exceptions;
using StoreProject.Application.ProductItems.Requests.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.ProductItems.Handlers.Commands
{
    public class UpdateProductItemCommandHandler : IRequestHandler<UpdateProductItemCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateProductItemCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateProductItemCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateProductItemDtoValidator(_unitOfWork.ProductRepository);
            var validatorResult = await validator.ValidateAsync(request.ProductItemDto);

            if (validatorResult.IsValid == false)
            {
                throw new ValidationException(validatorResult);
            }

            var productItem = await _unitOfWork.ProductItemRepository.Get(request.ProductItemDto.Id);

            _mapper.Map(request.ProductItemDto, productItem);


            await _unitOfWork.ProductItemRepository.Update(productItem);
            await _unitOfWork.Save();

            return Unit.Value;
        }
    }
}
