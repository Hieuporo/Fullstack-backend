using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Application.Contracts.IReposiotry
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(string id);
        Task<IReadOnlyList<T>> GetAll();
        Task<T> Add(T entity);
        Task<bool> Exists(string id);
        Task Update(T entity);
        Task Delete(T entity);

    }
}
