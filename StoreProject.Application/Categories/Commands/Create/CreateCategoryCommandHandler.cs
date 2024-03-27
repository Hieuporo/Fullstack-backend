using MediatR;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Application.Exceptions;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Categories.Commands.Create
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, int>
    {
        public readonly ICategoryRepository _categoryRepository;
        public readonly IUnitOfWork _unitOfWork;

        public CreateCategoryCommandHandler(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<int> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var IsExists = _categoryRepository.FindByName(request.Name);

            if (IsExists != null) {
                throw new BadRequestException("Category name is already used");
            }

            var category = new Category { Name = request.Name , Description = request.Description, Image = request.Image };

            await _categoryRepository.Add(category);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return category.Id;
        }
    }
}
