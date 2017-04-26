using LivrariaEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaEF.Repositories
{
    public class ShelfRepository : IShelfRepository
    {
        private DatabaseContext _db;

        public ShelfRepository(DatabaseContext db)
        {
            this._db = db;
        }

        public IEnumerable<Shelf> Get()
        {
            return _db.Shelfs.ToList();
        }

        public Shelf GetByID(int id)
        {
            return _db.Shelfs.Find(id);
        }

        public void Add(Shelf room)
        {
            _db.Shelfs.Add(room);
        }

        public void Delete(int id)
        {
            var room = GetByID(id);
            _db.Shelfs.Remove(room);
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
