using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaEF.Models
{
    public class Shelf
    {
        public Shelf()
        {

        }

        public int ShelfId { get; set; }

        public int Number { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
