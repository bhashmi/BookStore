using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Entities
{
    public class Pub_Info
    {
        public Pub_Info()
        {
        }
        public virtual int pub_id { get; set; }
        public virtual byte[] logo { get; set; }
        public virtual string pr_info { get; set; }
    }
}
