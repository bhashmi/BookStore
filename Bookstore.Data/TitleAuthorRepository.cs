using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bookstore.Entities;


namespace Bookstore.Data
{
    public class TitleAuthorRepository : IRepository<TitleAuthor>, IDisposable
    {
        private BookStoreContext _context;

        public TitleAuthorRepository(BookStoreContext context)
        {
            this._context = context;
        }

        public IEnumerable<TitleAuthor> GetAll()
        {
            return this._context.TitleAuthors.ToList();
        }

        public TitleAuthor GetByKey(int key)
        {
            return this._context.TitleAuthors.Find(key);
        }

        public void Insert(TitleAuthor entity)
        {
            this._context.TitleAuthors.Add(entity);
        }

        public void Delete(int key)
        {
            TitleAuthor titleAuthor = GetByKey(key);
            this._context.TitleAuthors.Remove(titleAuthor);
        }

        public void Update(TitleAuthor entity)
        {
            this._context.Entry(entity).State = System.Data.EntityState.Modified;
        }

        public void Save()
        {
            this._context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
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
