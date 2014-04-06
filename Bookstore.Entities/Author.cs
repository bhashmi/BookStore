using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Entities
{
    public class Author
    {
        public Author()
        {}
        public virtual int au_id { get; set; }
        public virtual string au_fname { get; set; }
        public virtual string au_lname { get; set; }
        public virtual string phone { get; set; }
        public virtual string address { get; set; }
        public virtual string city { get; set; }
        public virtual string state { get; set; }
        public virtual string zip { get; set; }
        public virtual bool contract { get; set; }
        
    }
}
