using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using StoreProject.Application.Contracts.Infrastructure;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Application.DTOs.Brand.Validators;
using StoreProject.Application.Exceptions;
using StoreProject.Application.Features.Brands.Requests.Commands;
using StoreProject.Application.Models;
using StoreProject.Domain.Entities;
using System.Security.Claims;

namespace StoreProject.Application.Features.Brands.Handlers.Commands
{
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IEmailSender _emailSender;
        private readonly IMapper _mapper;

        public CreateBrandCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IEmailSender emailSender, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _emailSender = emailSender;
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


            var emailAddress = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;

            var email = new Email
            {
                To = "hieucobappp@gmail.com",
                Body = $"Created" +
                    $"successfully.",
                Subject = "Test email"
            };

            await _emailSender.SendEmail(email);


            return brand.Id;
        }
    }
}
