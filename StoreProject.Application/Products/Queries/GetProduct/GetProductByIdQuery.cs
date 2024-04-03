using MediatR;
using StoreProject.Application.DTOs.Product;


namespace StoreProject.Application.Products.Queries.GetProduct
{
    public class GetProductByIdQuery : IRequest<ProductDto>
    {
        public int Id { get; set; }
    }
}
