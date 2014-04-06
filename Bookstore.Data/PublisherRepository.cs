using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bookstore.Entities;

namespace Bookstore.Data
{
    public class PublisherRepository : IRepository<Publisher>, IDisposable
    {
        private BookStoreContext _context;

        public PublisherRepository(BookStoreContext context)
        {
            this._context = context;
        }

        public IEnumerable<Publisher> GetAll()
        {
            return _context.Publisher.ToList();
        }

        public Publisher GetByKey(int key)
        {
            return _context.Publisher.Find(key);
        }

        public void Insert(Publisher entity)
        {
            _context.Publisher.Add(entity);
        }

        public void Delete(int key)
        {
            Publisher publisher = GetByKey(key);
            _context.Publisher.Remove(publisher);
        }

        public void Update(Publisher entity)
        {
            _context.Entry(entity).State = System.Data.EntityState.Modified;
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
