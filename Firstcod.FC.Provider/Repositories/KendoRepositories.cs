using Firstcod.FC.Provider.Models;
using Firstcod.FC.Provider.Providers;
using Firstcod.FC.Provider.RepositoriesInterface;
using Microsoft.EntityFrameworkCore;

namespace Firstcod.FC.Provider.Repositories
{
    public class KendoRepositories : GenericRepositories<Kendo>, IKendoRepositories
    {
        public KendoRepositories(DbContext context) 
            : base(context) { }

        private ApplicationDbContext _applicationDbContext => (ApplicationDbContext)_context;
    }
}
