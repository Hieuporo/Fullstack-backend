using StoreProject.Application.Contracts.IReposiotry;
using StoreProject.Domain.Entities;
using StoreProject.Infrastructure.Data;


namespace StoreProject.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository 
    {
        private readonly ApplicationDbContext _dbContext;
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public User FindByEmail(string email)
        {
           return _dbContext.Users.Where(u => u.Email == email).FirstOrDefault();
        }
    }
}
