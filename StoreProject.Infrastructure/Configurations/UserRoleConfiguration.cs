using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreProject.Domain.Constants;
using StoreProject.Domain.Entities;

namespace StoreProject.Infrastructure.Configurations
{
	public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
	{
		public void Configure(EntityTypeBuilder<UserRole> builder)
		{

			builder.HasKey(x => new { x.RoleId, x.UserId });

			builder.HasData(
				 new UserRole
				 {
					UserId = 1,
					RoleId = RoleDefault.ADMIN
				 }
			);

		}
	}
}
