using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bookstore.Entities;

namespace Bookstore.Data
{
    public class StoreRepository : IRepository<Store>, IDisposable
    {
        private BookStoreContext _context;

        public StoreRepository(BookStoreContext context)
        {
            this._context = context;
        }

        public IEnumerable<Store> GetAll()
        {
            return _context.Stores.ToList();
        }

        public Store GetByKey(int key)
        {
            return _context.Stores.Find(key);
        }

        public void Insert(Store entity)
        {
            _context.Stores.Add(entity);
        }

        public void Delete(int key)
        {
            Store store = GetByKey(key);
            _context.Stores.Remove(store);
        }

        public void Update(Store entity)
        {
            _context.Entry(entity).State = System.Data.EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
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
