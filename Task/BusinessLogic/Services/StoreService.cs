using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess.Entitites;
using DataAcess.Interfaces;
using DataAcess.Repositories;

namespace BusinessLogic.Services
{
    public class StoreService : IDisposable
    {
        private readonly IRepository<Store> _storeRepository;

        private bool _disposed;

        public StoreService(IRepository<Store> storeRepository)
        {
            _storeRepository = storeRepository;
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
                    _storeRepository.Dispose();
                }

                _disposed = true;
            }
        }
    }
}
