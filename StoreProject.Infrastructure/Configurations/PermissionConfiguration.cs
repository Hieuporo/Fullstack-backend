using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreProject.Domain.Entities;
using StoreProject.Domain.Enums;

namespace StoreProject.Infrastructure.Configurations
{
	public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
	{
		public void Configure(EntityTypeBuilder<Permission> builder)
		{

			IEnumerable<Permission> permissions = Enum
				.GetValues<PermissionList>()
				.Select(p => new Permission
				{
					Id = (int)p,
					Name = p.ToString()
				});


			builder.HasData(permissions);											
		}
	}
}
