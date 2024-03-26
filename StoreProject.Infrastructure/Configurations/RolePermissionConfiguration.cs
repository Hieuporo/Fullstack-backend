using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using StoreProject.Domain.Constants;
using StoreProject.Domain.Entities;
using StoreProject.Domain.Enums;

namespace StoreProject.Infrastructure.Configurations
{
	public class RolePermissionConfiguration : IEntityTypeConfiguration<RolePermission>
	{
		public void Configure(EntityTypeBuilder<RolePermission> builder)
		{

			builder.HasKey(x => new { x.RoleId, x.PermissionId });

			// config default perm for admin
            IEnumerable<Permission> permissions = Enum
                .GetValues<PermissionList>()
				.Where(p => p != PermissionList.Client)
                .Select(p => new Permission
                {
                    Id = (int)p,
                    Name = p.ToString()
                });

			foreach(var p in permissions) {
                builder.HasData(
					Create(RoleDefault.ADMIN, p)
				);
            }
            IEnumerable<Permission> permissionUsers = Enum
                .GetValues<PermissionList>()
                .Where(p => p == PermissionList.Client || p == PermissionList.All)
                .Select(p => new Permission
                {
                    Id = (int)p,
                    Name = p.ToString()
                });

            // config default perm for user
            foreach (var p in permissionUsers)
            {
                builder.HasData(
                    Create(RoleDefault.USER, p)
                );
            }

        }

		private static RolePermission Create(int RoleId, Permission permission) {

			return new RolePermission
			{
				RoleId = RoleId,
				PermissionId = permission.Id
            };
		}

	}
}
