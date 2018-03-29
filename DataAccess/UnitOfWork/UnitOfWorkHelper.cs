using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork
{
    class UnitOfWorkHelper : IDisposable
    {

        private DbContext context = null;

        public UnitOfWorkHelper(DbContext context)
        {
            this.context = context;
        }
        //Initialize Repositories
        private Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        public IRepository<T> Repository<T>() where T : class
        {
            if (repositories.Keys.Contains(typeof(T)))
            {
                return repositories[typeof(T)] as IRepository<T> ;
            }
            IRepository<T> repository = new Repository<T>(context);
            return repository;
        }

        public void SaveChanges()
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void SaveChangesAsync()
        {
            try
            {
                context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private bool disposed = false;
        public void Dispose( bool dispose )
        {
            try
            {
                if (!this.disposed)
                {
                    context.Dispose();
                }
                this.disposed= true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
