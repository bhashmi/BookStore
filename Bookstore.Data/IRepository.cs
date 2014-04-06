using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Data
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetByKey(int key);
        void Insert(TEntity entity);
        void Delete(int key);
        void Update(TEntity entity);
        void Save();
    }
}
