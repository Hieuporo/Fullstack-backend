using Microsoft.AspNetCore.Http;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Infrastructure.Data;


namespace StoreProject.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

		public UnitOfWork(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
