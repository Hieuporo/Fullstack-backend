using Microsoft.EntityFrameworkCore;
using StoreProject.Application.Contracts.IReposiotry;
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


   //     public List<Product> GetProductsWithProductItem(string? SearchTerm, int? CategoryId)
   //     {
   //         IQueryable<Product> query = _dbContext.Products;
            
			//if (CategoryId != null)
			//{
			//	query = query.Where(u => u.CategoryId == CategoryId);
			//}
			//if (!String.IsNullOrEmpty(SearchTerm))
   //         {
			//	query = query.Where(u => u.Name.Contains(SearchTerm));
			//}
   //         return query.Include(p => p.ProductItems).ToList();
   //     }
    }
}
