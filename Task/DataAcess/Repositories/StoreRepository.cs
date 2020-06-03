using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess.Entitites;
using DataAcess.Interfaces;

namespace DataAcess.Repositories
{
    public class StoreRepository : IRepository<Store>
    {
        private bool _disposed;

        public StoreRepository(string connectionString)
        {
            DataContext = new DataContext(connectionString);
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
                if(disposing)
                {
                    DataContext.Dispose();
                }

                _disposed = true;
            }
        }
    }
}
