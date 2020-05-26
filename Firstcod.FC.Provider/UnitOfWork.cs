using Firstcod.FC.Provider.Repositories;
using Firstcod.FC.Provider.RepositoriesInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Firstcod.FC.Provider
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        IUserRepositories _userRepositories;
        public IUserRepositories User
        {
            get
            {
                if (_userRepositories == null)
                    _userRepositories = new UserRepositories(_context);

                return _userRepositories;
            }
        }

        IKendoRepositories _kendoRepositories;
        public IKendoRepositories Kendo
        {
            get
            {
                if (_kendoRepositories == null)
                    _kendoRepositories = new KendoRepositories(_context);

                return _kendoRepositories;
            }
        }
    }
}
