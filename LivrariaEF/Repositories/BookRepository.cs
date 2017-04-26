using LivrariaEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaEF.Repositories
{
    public class BookRepository : IBookRepository
    {
        private DatabaseContext _databaseContext;

        public BookRepository(DatabaseContext databaseContext)
        {
            this._databaseContext = databaseContext;
        }

        public IEnumerable<Book> Get()
        {
            return _databaseContext.Books.ToList();
        }

        public Book GetByID(int id)
        {
            return _databaseContext.Books.Find(id);
        }

        public void Add(Book book)
        {
            _databaseContext.Books.Add(book);
        }

        public void Delete(int id)
        {
            var book = GetByID(id);
            _databaseContext.Books.Remove(book);
        }

        public void Dispose()
        {
            _databaseContext.Dispose();
        }
    }
}
