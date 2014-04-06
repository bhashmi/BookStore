using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Entities
{
    public class Jobs
    {
        public Jobs()
        {
        }

        public virtual int job_id { get; set; }
        public virtual string job_desc { get; set; }
        public virtual int min_lvl { get; set; }
        public virtual int max_lvl { get; set; }
    }
}
