using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Entities
{
    public class RoySched
    {
        public RoySched() { }
        public virtual string title_id { get; set; }
        public virtual int lorange { get; set; }
        public virtual int hirange { get; set; }
        public virtual int royalty { get; set; }

    }
}
