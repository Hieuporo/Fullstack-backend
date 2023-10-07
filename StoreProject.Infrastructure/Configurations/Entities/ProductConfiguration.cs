using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Infrastructure.Configurations.Entities
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
               .HasMany(e => e.ProductItems)
               .WithOne(e => e.Product)
               .HasForeignKey(e => e.ProductId)
               .HasPrincipalKey(e => e.Id);

            builder
               .HasMany(e => e.ProductTags)
               .WithOne(e => e.Product)
               .HasForeignKey(e => e.ProductId)
               .HasPrincipalKey(e => e.Id);

        }
    }
}
