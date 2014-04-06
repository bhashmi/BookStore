using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Entities
{
    public class Store
    {
        public Store() { }
        public virtual int stor_id { get; set; }
        public virtual string stor_name { get; set; }
        public virtual string stor_address { get; set; }
        public virtual string city { get; set; }
        public virtual string state { get; set; }
        public virtual string zip { get; set; }
    }
}
