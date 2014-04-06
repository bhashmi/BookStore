using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Entities
{
    public class Sales
    {
        public Sales() {
            this.Titles = new List<Title>();
        }
        public virtual int stor_Id { get; set; }
        public virtual string ord_num { get; set; }
        public virtual string payterm { get; set; }
        public virtual DateTime ord_date { get; set; }
        public virtual int qty { get; set; }
        public virtual string title_id { get; set; }
        public virtual ICollection<Title> Titles { get; set; }

    }
}
