using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Infrastructure.Configurations.Entities
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
               .HasMany(e => e.OrderItems)
               .WithOne(e => e.Order)
               .HasForeignKey(e => e.OrderId)
               .HasPrincipalKey(e => e.Id);

            builder
              .HasOne(e => e.User)
              .WithMany(e => e.Orders)
              .HasForeignKey(e => e.UserId)
              .HasPrincipalKey(e => e.Id);
        }
    }
}
