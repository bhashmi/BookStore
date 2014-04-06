using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Bookstore.Entities;

namespace Bookstore.Data
{
    public class BookStoreContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Jobs> Jobs { get; set; }
        public DbSet<Pub_Info> Pub_Info { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<RoySched> RoySched { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<TitleAuthor> TitleAuthors { get; set; }


    }
}
