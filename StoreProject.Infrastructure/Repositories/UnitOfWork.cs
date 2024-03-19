using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Domain.Common;
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

        public Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            UpdateAuditableEntities();

            return _context.SaveChangesAsync(cancellationToken);
        }

        private void UpdateAuditableEntities()
        {
            IEnumerable<EntityEntry<BaseDomainEntity>> entries =
                _context
                    .ChangeTracker
                    .Entries<BaseDomainEntity>();

            foreach (EntityEntry<BaseDomainEntity> entityEntry in entries)
            {
                if (entityEntry.State == EntityState.Added)
                {
                    entityEntry.Property(a => a.CreatedAt)
                        .CurrentValue = DateTime.UtcNow;
                }

                if (entityEntry.State == EntityState.Modified)
                {
                    entityEntry.Property(a => a.LastModified)
                        .CurrentValue = DateTime.UtcNow;
                }
            }
        }
    }
}
