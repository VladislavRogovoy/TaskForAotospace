using System;
using System.Linq;

namespace DataAcess.Interfaces
{
    public interface IRepository<T> : IDisposable
        where T : class
    {
        IQueryable<T> All();
    }
}
