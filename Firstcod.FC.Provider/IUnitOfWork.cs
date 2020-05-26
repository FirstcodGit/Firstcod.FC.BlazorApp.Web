using Firstcod.FC.Provider.RepositoriesInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Firstcod.FC.Provider
{
    public interface IUnitOfWork
    {
        IUserRepositories User { get; }
        IKendoRepositories Kendo { get; }
    }
}
