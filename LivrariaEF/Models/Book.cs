using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaEF.Models
{
    public class Book
    {
        public Book()
        {

        }

        public int BookId { get; set; }

        public string Name { get; set; }

        public int ShelfId { get; set; }
        public virtual Shelf Shelf { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
    }
}
