using System;
using System.Configuration;
using System.Data.Linq;
using System.Linq;
using DataAcess.Entities;
using DataAcess.Interfaces;

namespace DataAcess.Repositories
{
    public class StoreRepository : IRepository<Store>
    {
        private bool _disposed;

        public StoreRepository()
        {
            DataContext = new DataContext(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }

        private DataContext DataContext { get; }

        public IQueryable<Store> All()
        {
            return DataContext.GetTable<Store>();
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
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
