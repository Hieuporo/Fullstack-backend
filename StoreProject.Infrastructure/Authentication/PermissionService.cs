using Microsoft.EntityFrameworkCore;
using StoreProject.Infrastructure.Data;

namespace StoreProject.Infrastructure.Authentication
{
	public class PermissionService : IPermissionService
	{
		private readonly ApplicationDbContext _context;

		public PermissionService(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<HashSet<string>> GetPermissionsAsync(int userId)
		{
			var roles = _context.UserRoles
				   .Where(x => x.UserId == userId)
				   .Include(x => x.Role)
				   .Select(x => x.Role);

			var perms = new HashSet<string>();

			foreach(var role in roles)
			{
				var perm = _context.RolePermissions
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
