using System;
using System.Collections.Generic;
using System.Text;

namespace Firstcod.FC.Provider
{
    public class HttpUnitOfWork : UnitOfWork
    {
        public HttpUnitOfWork(ApplicationDbContext context) 
            : base(context) { }
    }
}
