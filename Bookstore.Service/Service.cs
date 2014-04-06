using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Bookstore.Data;

namespace Bookstore.Service
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class 
    {
        private readonly IRepository<TEntity> _repository;

        public Service(IRepository<TEntity> repo)
        {
            _repository = repo;
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetByKey(int key)
        {
            return _repository.GetByKey(key);
        }

        public void Insert(TEntity entity)
        {
            _repository.Insert(entity);
        }

        public void Delete(int key)
        {
            _repository.Delete(key);
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }

        public void Save()
        {
            _repository.Save();
        }
    }
}
