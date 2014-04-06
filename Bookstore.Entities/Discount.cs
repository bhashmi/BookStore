using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Entities
{
    public class Discount
    {
        public Discount() { }

        public virtual string DiscountType { get; set; }
        public virtual int StoreId { get; set; }
        public virtual decimal lowqty { get; set; }
        public virtual decimal highqty { get; set; }
        public virtual decimal discount { get; set; }

    }
}
