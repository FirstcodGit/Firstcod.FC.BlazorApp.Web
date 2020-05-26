using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Firstcod.FC.Provider.Providers
{
    public interface IGenericRepositories<T> where T: class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> FindList(Expression<Func<T, bool>> predicate);
        T FindById(Expression<Func<T, bool>> predicate);

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        void Save();
    }
}
