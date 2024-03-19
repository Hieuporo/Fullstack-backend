using StoreProject.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace Eshopz.Infrastructure.Configurations
{
	public class UserConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.HasData(
			 new User
			 {
				 Id = 1,
				 Email = "admin@gmail.com",
				 Password = "Admin123*"
			 }
		 );
		}
	}
}
