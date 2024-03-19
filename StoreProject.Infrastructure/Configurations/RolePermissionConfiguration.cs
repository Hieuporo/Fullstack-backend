using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using StoreProject.Domain.Constants;
using StoreProject.Domain.Entities;

namespace StoreProject.Infrastructure.Configurations
{
	public class RolePermissionConfiguration : IEntityTypeConfiguration<RolePermission>
	{
		public void Configure(EntityTypeBuilder<RolePermission> builder)
		{

			builder.HasKey(x => new { x.RoleId, x.PermissionId });
			builder.HasData(
				Create(RoleDefault.ADMIN, PermissionList.CreateBrand)
		   );
		}

		private static RolePermission Create(int RoleId, PermissionList permission) {

			return new RolePermission
			{
				RoleId = RoleId,
				PermissionId = (int)permission
			};
		}

	}
}
