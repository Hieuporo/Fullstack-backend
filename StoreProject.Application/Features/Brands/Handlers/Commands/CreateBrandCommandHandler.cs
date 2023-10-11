using AutoMapper;
using MediatR;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Application.DTOs.Brand.Validators;
using StoreProject.Application.Exceptions;
using StoreProject.Application.Features.Brands.Requests.Commands;
using StoreProject.Domain.Entities;

namespace StoreProject.Application.Features.Brands.Handlers.Commands
{
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateBrandCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateBrandDtoValidator();
            var validatorResult = await validator.ValidateAsync(request.BrandDto);

            if (validatorResult.IsValid == false)
            {
                throw new ValidationException(validatorResult);
            }
            var brand = _mapper.Map<Brand>(request.BrandDto);
            brand = await _unitOfWork.BrandRepository.Add(brand);
            await _unitOfWork.Save();

            return brand.Id;
        }
    }
}
