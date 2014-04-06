using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Entities
{
    public class Publisher
    {
        public Publisher() { }
        public virtual int pub_Id { get; set; }
        public virtual string pub_name { get; set; }
        public virtual string city { get; set; }
        public virtual string state { get; set; }
        public virtual string country { get; set; }
    }
}
