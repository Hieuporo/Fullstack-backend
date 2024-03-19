using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using StoreProject.Domain.Common;
using StoreProject.Domain.Entities;

namespace StoreProject.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public IMongoCollection<Brand> Brands { get; set; }
        public IMongoCollection<Role> Roles { get; set; }
        public IMongoCollection<User> Users { get; set; }
        public IMongoCollection<UserRole> UserRoles { get; set; }
        public IMongoCollection<Permission> Permissions { get; set; }
        public IMongoCollection<RolePermission> RolePermissions { get; set; }

        //public IMongoCollection<Product> Products { get; }

        //public IMongoCollection<Coupon> Coupons { get; set; }

        //public IMongoCollection<ShippingMethod> ShippingMethods { get; set; }
        //public IMongoCollection<Category> Categories { get; set; }
        //public IMongoCollection<Cart> Carts { get; set; }
        //public IMongoCollection<CartItem> CartItems { get; set; }
        //public IMongoCollection<Order> Orders { get; set; }
        //public IMongoCollection<OrderItem> OrderItems { get; set; }
        //public IMongoCollection<ProductItem> ProductItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
       
        public virtual async Task<int> SaveChangesAsync(string username = "SYSTEM")
        {
            foreach (var entry in base.ChangeTracker.Entries<BaseDomainEntity>()
                .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
            {
                entry.Entity.LastModified = DateTime.Now;
                entry.Entity.LastModifiedBy = username;

                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedAt = DateTime.Now;
                    entry.Entity.CreatedBy = username;
                }
            }

            var result = await base.SaveChangesAsync();

            return result;
        }

    }
}
