using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess.Interfaces;
using DataAcess.Entitites;
using System.Data.Linq;

namespace DataAcess.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private bool _disposed;

        public ProductRepository(string connectionSctring)
        {
            DataContext = new DataContext(connectionSctring);
        }

        private DataContext DataContext { get; }

        public IQueryable<Product> All()
        {
            return DataContext.GetTable<Product>();
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    DataContext.Dispose();
                }

                _disposed = true;
            }
        }
    }
}
