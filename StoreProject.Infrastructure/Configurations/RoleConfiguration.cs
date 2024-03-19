using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreProject.Domain.Constants;
using StoreProject.Domain.Entities;

namespace StoreProject.Infrastructure.Configurations
{
	public class RoleConfiguration : IEntityTypeConfiguration<Role>
	{
		public void Configure(EntityTypeBuilder<Role> builder)
		{

			builder.HasData(
				new Role
			    {
				   Id = RoleDefault.ADMIN,
				   Name = nameof(RoleDefault.ADMIN),
			    },
				new Role
				{
					Id = RoleDefault.USER,
					Name = nameof(RoleDefault.USER),
				}
		   );
		}
	}
}
