using MediatR;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Domain.Entities;


namespace StoreProject.Application.Brands.Commands.CreateBrand
{
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBrandRepository _brandRepository;

        public CreateBrandCommandHandler(IUnitOfWork unitOfWork, IBrandRepository brandRepository)
        {
            _unitOfWork = unitOfWork;
            _brandRepository = brandRepository;
        }

        public async Task<int> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {


            var brand = new Brand
            {
                Name = request.Name
            };
            
            await _brandRepository.Add(brand);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return brand.Id;

        }
    }
}
