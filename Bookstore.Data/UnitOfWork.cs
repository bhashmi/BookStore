using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Data
{
    public class UnitOfWork : IDisposable
    {
        private BookStoreContext context = new BookStoreContext();
        private AuthorRepository authorRepository = null;
        private EmployeeRepository employeeRepository = null;
        private JobRepository jobRepository = null;
        private PublisherRepository publisherRepository = null;
        private SalesRepository salesRepository = null;
        private StoreRepository storeRepository = null;
        private TitleAuthorRepository titleAuthorRepository = null;
        private TitleRepository titleRepository = null;
        

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
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
