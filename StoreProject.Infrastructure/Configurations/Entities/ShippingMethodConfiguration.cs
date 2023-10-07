﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Infrastructure.Configurations.Entities
{
    public class ShippingMethodConfiguration : IEntityTypeConfiguration<ShippingMethod>
    {
        public void Configure(EntityTypeBuilder<ShippingMethod> builder)
        {
            builder
              .HasMany(e => e.Orders)
              .WithOne(e => e.ShippingMethod)
              .HasForeignKey(e => e.ShippingMethodId)
              .HasPrincipalKey(e => e.Id);

        }
    }
}
