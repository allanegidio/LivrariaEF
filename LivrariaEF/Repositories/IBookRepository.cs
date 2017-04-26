using LivrariaEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaEF.Repositories
{
    public interface IBookRepository : IDisposable
    {
        IEnumerable<Book> Get();
        Book GetByID(int id);
        void Add(Book book);
        void Delete(int id);
    }
}
