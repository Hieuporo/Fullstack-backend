using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Application.DTOs.Tag.Validators;
using StoreProject.Application.Exceptions;
using StoreProject.Application.Features.Tags.Requests.Commands;
using StoreProject.Domain.Entities;

namespace StoreProject.Application.Features.Tags.Handlers.Commands
{
    public class CreateTagCommandHandler : IRequestHandler<CreateTagCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateTagCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateTagDtoValidator();
            var validatorResult = await validator.ValidateAsync(request.TagDto);

            if (validatorResult.IsValid == false)
            {
                throw new ValidationException(validatorResult);
            }
            var tag = _mapper.Map<Tag>(request.TagDto);
            tag = await _unitOfWork.TagRepository.Add(tag);
            await _unitOfWork.Save();

            return tag.Id;
        }
    }
}
