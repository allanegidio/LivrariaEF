using LivrariaEF.Models;
using System;
using System.Collections.Generic;

namespace LivrariaEF.Repositories
{
    public interface IShelfRepository : IDisposable
    {
        IEnumerable<Shelf> Get();
        Shelf GetByID(int id);
        void Add(Shelf room);
        void Delete(int id);
    }
}
