using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bookstore.Entities;

namespace Bookstore.Data
{
    public class JobRepository : IRepository<Jobs>, IDisposable
    {
        private BookStoreContext _context;

        public JobRepository(BookStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Jobs> GetAll()
        {
            return _context.Jobs.ToList();
        }

        public Jobs GetByKey(int key)
        {
            return _context.Jobs.Find(key);
        }

        public void Insert(Jobs entity)
        {
            _context.Jobs.Add(entity);
        }

        public void Delete(int key)
        {
            Jobs job = GetByKey(key);
            _context.Jobs.Remove(job);
        }

        public void Update(Jobs entity)
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
