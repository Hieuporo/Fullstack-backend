using Microsoft.EntityFrameworkCore;
using StoreProject.Infrastructure.Data;

namespace StoreProject.Infrastructure.Authentication
{
	public class PermissionService : IPermissionService
	{
        private readonly ApplicationDbContext _dbContext;

        public PermissionService(ApplicationDbContext dbContext)
		{
            _dbContext = dbContext;
        }

		public async Task<HashSet<string>> GetPermissionsAsync(int userId)
		{
			var roles = await _dbContext.UserRoles
				   .Where(x => x.UserId == userId)
				   .Include(x => x.Role)
				   .Select(x => x.Role).ToListAsync();;

			var perms = new HashSet<string>();

			foreach(var role in roles)
			{
				var perm = _dbContext.RolePermissions
					.Where(x => x.RoleId == role.Id)
					.Include(x => x.Permission)
					.Select(x => x.Permission.Name)
					.ToHashSet();

				perms.UnionWith(perm);
			}

			return perms;

		}
	}
}
