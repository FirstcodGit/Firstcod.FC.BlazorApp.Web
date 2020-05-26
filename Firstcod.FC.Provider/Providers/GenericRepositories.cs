using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Firstcod.FC.Provider.Providers
{
    public class GenericRepositories<T> : IDisposable, IGenericRepositories<T> where T : class
    {
        protected readonly DbContext _context;

        protected readonly DbSet<T> _entity;

        public GenericRepositories(DbContext context)
        {
            _context = context;
            _entity = _context.Set<T>();
        }

        public T FindById(Expression<Func<T, bool>> predicate)
        {
            return _entity.SingleOrDefault(predicate);
        }

        public IEnumerable<T> FindList(Expression<Func<T, bool>> predicate)
        {
            return _entity.Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return _entity.ToList();
        }

        public void Add(T entity)
        {
            _entity.Add(entity);
        }

        public void Delete(T entity)
        {
            _entity.Remove(entity);
        }

        public void Update(T entity)
        {
            _entity.Update(entity);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
