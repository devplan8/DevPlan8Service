using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    interface IRepository<TEntity> where TEntity:class
    {
        IEnumerable<TEntity> Get();

        TEntity GetById(object id);

        void Insert(TEntity entity);

        void Delete(TEntity entity);

        void Delete(object id);

        void Update(TEntity entity);

    }
}
