using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaEF.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
