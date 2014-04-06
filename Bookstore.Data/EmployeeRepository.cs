using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bookstore.Entities;

namespace Bookstore.Data
{
    public class EmployeeRepository : IRepository<Employee>, IDisposable
    {
        private BookStoreContext _context;

        public EmployeeRepository(BookStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee GetByKey(int key)
        {
            return _context.Employees.Find(key);
        }

        public void Insert(Employee entity)
        {
            _context.Employees.Add(entity);
        }

        public void Delete(int key)
        {
            Employee employee = GetByKey(key);
            _context.Employees.Remove(employee);
        }

        public void Update(Employee entity)
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
