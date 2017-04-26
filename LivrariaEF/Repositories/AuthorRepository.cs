using LivrariaEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaEF.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private DatabaseContext _db;

        public AuthorRepository(DatabaseContext db)
        {
            this._db = db;
        }

        public IEnumerable<Author> Get()
        {
            return _db.Authors.ToList();
        }

        public Author GetByID(int id)
        {
            return _db.Authors.Find(id);
        }

        public void Add(Author room)
        {
            _db.Authors.Add(room);
        }

        public void Delete(int id)
        {
            var room = GetByID(id);
            _db.Authors.Remove(room);
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
