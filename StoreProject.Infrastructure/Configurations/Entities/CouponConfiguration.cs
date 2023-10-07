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
    public class CouponConfiguration : IEntityTypeConfiguration<Coupon>
    {
        public void Configure(EntityTypeBuilder<Coupon> builder)
        {
            builder.HasData(
                new Coupon
                {
                    Id = 1,
                    CouponCode = "100FF",
                    MinAmount = 100,
                    DiscountAmount = 10
                },
                 new Coupon
                 {
                     Id = 2,
                     CouponCode = "200FF",
                     MinAmount = 150,
                     DiscountAmount = 20
                 }
            );
        }
    }
}
