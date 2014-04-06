
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bookstore.Entities;

namespace Bookstore.Data
{
    public class TitleRepository : IRepository<Title>, IDisposable
    {
        private BookStoreContext _context;

        public TitleRepository(BookStoreContext context)
        {
            this._context = context;
        }

        public IEnumerable<Title> GetAll()
        {
            return this._context.Titles.ToList();
        }

        public Title GetByKey(int key)
        {
            return this._context.Titles.Find(key);
        }

        public void Insert(Title entity)
        {
            this._context.Titles.Add(entity);
        }

        public void Delete(int key)
        {
            Title title = GetByKey(key);
            this._context.Titles.Remove(title);
        }

        public void Update(Title entity)
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
