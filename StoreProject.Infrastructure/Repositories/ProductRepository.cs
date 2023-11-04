using Microsoft.EntityFrameworkCore;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Domain.Entities;
using StoreProject.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Infrastructure.Repositories
{
    public class ProductRepository : GenericRepository<Product> , IProductRepository
    {
         private readonly ApplicationDbContext _dbContext;
        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Product GetProductWithProductItem(int productId)
        {
            return _dbContext.Products.Include(p => p.ProductItems)
                .FirstOrDefault(p => p.Id == productId); ;
        }
    

        public List<Product> GetProductsWithProductItem(string? SearchTerm)
        {
            if (!String.IsNullOrEmpty(SearchTerm))
            {
                return _dbContext.Products.Include(p => p.ProductItems)
                    .Where(u => u.Name.Contains(SearchTerm)).ToList();
            }
            return _dbContext.Products.Include(p => p.ProductItems).ToList();
        }
    }
}
