using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Entities
{
    public class TitleAuthor 
    {
        public TitleAuthor() { 
            this.Titles = new List<Title>();
            this.Authors = new List<Author>();
        }
        public virtual string au_id { get; set; }
        public virtual string title_id { get; set; }
        public virtual int au_ord { get; set; }
        public virtual decimal royaltyper { get; set; }
        public virtual ICollection<Title> Titles { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
    }
}
