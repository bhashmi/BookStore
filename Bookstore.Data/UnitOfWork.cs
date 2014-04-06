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


        public AuthorRepository AuthorRepository
        {
            get
            {
                if (authorRepository == null)
                    authorRepository = new AuthorRepository(context);

                return authorRepository;
            }
        }

        public EmployeeRepository EmployeeRepository
        {
            get
            {
                if (employeeRepository == null)
                    employeeRepository = new EmployeeRepository(context);

                return employeeRepository;
            }
        }

        public JobRepository JobRepository
        {
            get
            {
                if (jobRepository == null)
                    jobRepository = new JobRepository(context);

                return jobRepository;
            }
        }

        public PublisherRepository PublisherRepository
        {
            get
            {
                if (publisherRepository == null)
                    publisherRepository = new PublisherRepository(context);

                return publisherRepository;
            }
        }

        public SalesRepository SalesRepository
        {
            get
            {
                if (salesRepository == null)
                    salesRepository = new SalesRepository(context);

                return salesRepository;
            }
        }

        public StoreRepository StoreRepository
        {
            get
            {
                if (storeRepository == null)
                    storeRepository = new StoreRepository(context);

                return storeRepository;
            }
        }

        public TitleAuthorRepository TitleAuthorRepository
        {
            get
            {
                if (titleAuthorRepository == null)
                    titleAuthorRepository = new TitleAuthorRepository(context);

                return titleAuthorRepository;
            }
        }

        public TitleRepository TitleRepository
        {
            get
            {
                if (titleRepository == null)
                    titleRepository = new TitleRepository(context);

                return titleRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

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
