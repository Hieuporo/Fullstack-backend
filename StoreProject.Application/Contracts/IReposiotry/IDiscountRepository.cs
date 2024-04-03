using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Contracts.IReposiotry
{
    public interface IDiscountRepository : IGenericRepository<Discount>
    {
        Task<Discount?> GetDiscountByCode(string code);
        Task<List<Discount>> GetAvailableDiscounts(int userId);

    }
}
