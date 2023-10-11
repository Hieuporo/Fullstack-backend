using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Application.DTOs.Tag.Validators;
using StoreProject.Application.Exceptions;
using StoreProject.Application.Features.Tags.Requests.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Features.Tags.Handlers.Commands
{
    public class UpdateTagCommandHandler : IRequestHandler<UpdateTagCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateTagCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateTagDtoValidator();
            var validatorResult = await validator.ValidateAsync(request.TagDto);

            if (validatorResult.IsValid == false)
            {
                throw new ValidationException(validatorResult);
            }

            var tag = await _unitOfWork.TagRepository.Get(request.TagDto.Id);

            _mapper.Map(request.TagDto, tag);


            await _unitOfWork.TagRepository.Update(tag);
            await _unitOfWork.Save();

            return Unit.Value;
        }
    }
}
