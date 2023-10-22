using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Contracts.Infrastructure.IReposiotry
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Product GetProductWithProductItem(int productId);
        List<Product> GetProductsWithProductItem();
    }
}
