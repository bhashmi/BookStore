using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Entities
{
    public class Employee
    {
        public Employee() { }
        public virtual string emp_Id { get; set; }
        public virtual string fname { get; set; }
        public virtual string mint { get; set; }
        public virtual string lname { get; set; }
        public virtual int job_id { get; set; }
        public virtual int job_lvl { get; set; }
        public virtual int pub_id { get; set; }
        public DateTime hire_date { get; set; }
    }
}
