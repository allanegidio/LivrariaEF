using LivrariaEF.Models;
using System;
using System.Collections.Generic;

namespace LivrariaEF.Repositories
{
    public interface IAuthorRepository : IDisposable
    {
        IEnumerable<Author> Get();
        Author GetByID(int id);
        void Add(Author room);
        void Delete(int id);
    }
}
