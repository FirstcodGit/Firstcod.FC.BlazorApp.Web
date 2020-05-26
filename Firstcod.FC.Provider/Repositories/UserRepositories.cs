using Firstcod.FC.Provider.Models;
using Firstcod.FC.Provider.Providers;
using Firstcod.FC.Provider.RepositoriesInterface;
using Microsoft.EntityFrameworkCore;

namespace Firstcod.FC.Provider.Repositories
{
    public class UserRepositories : GenericRepositories<User>, IUserRepositories
    {
        public UserRepositories(DbContext context) 
            : base(context) { }

        private ApplicationDbContext _applicationDbContext => (ApplicationDbContext)_context;
    }
}
