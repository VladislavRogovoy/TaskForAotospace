using System;
using System.Collections.Generic;
using BusinessLogic.Exceptions;
using DataAcess.Entitites;
using DataAcess.Interfaces;

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

        public IEnumerable<Store> GetAll()
        {
            var stores = _storeRepository.All();
            if (stores == null)
            {
                throw new StoreException("stores not found");
            }

            return stores;
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
