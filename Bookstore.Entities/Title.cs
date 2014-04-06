using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Entities
{
    public class Title
    {
        public Title()
        { }

        public virtual string title_id { get; set; }
        public virtual string title { get; set; }
        public virtual string type { get; set; }
        public virtual int pub_id { get; set; }
        public virtual decimal price { get; set; }
        public virtual decimal advance { get; set; }
        public virtual int? royalty { get; set; }
        public virtual decimal? ytd_sales { get; set; }
        public virtual string notes { get; set; }
        public virtual DateTime pubdate { get; set; }
    }
}
