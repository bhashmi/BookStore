using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bookstore.Entities;

namespace Bookstore.Data
{
    public class AuthorRepository : IRepository<Author>, IDisposable
    {
        private BookStoreContext _schoolContext;

        public AuthorRepository(BookStoreContext context)
        {
            this._schoolContext = context;
        }

        public IEnumerable<Author> GetAll()
        {
            return _schoolContext.Authors.ToList();
        }

        public Author GetByKey(int key)
        {
            return _schoolContext.Authors.Find(key);
        }

        public void Insert(Author entity)
        {
            this._schoolContext.Authors.Add(entity);
        }

        public void Delete(int key)
        {
            Author author = GetByKey(key);
            _schoolContext.Authors.Remove(author);
        }

        public void Update(Author entity)
        {
            _schoolContext.Entry(entity).State = System.Data.EntityState.Modified;
        }

        public void Save()
        {
            _schoolContext.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _schoolContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
