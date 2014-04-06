using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bookstore.Entities;

namespace Bookstore.Data
{
    public class SalesRepository : IRepository<Sales>, IDisposable
    {
        private BookStoreContext _context = null;

        public SalesRepository(BookStoreContext context)
        {
            this._context = context;
        }

        public IEnumerable<Sales> GetAll()
        {
            return _context.Sales.ToList();
        }

        public Sales GetByKey(int key)
        {
            return _context.Sales.Find(key);
        }

        public void Insert(Sales entity)
        {
            this._context.Sales.Add(entity);
        }

        public void Delete(int key)
        {
            Sales sales = GetByKey(key);
            _context.Sales.Remove(sales);
        }

        public void Update(Sales entity)
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
