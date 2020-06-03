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
    public class ProductService : IDisposable
    {
        private readonly IRepository<Product> _productRepository;

        private bool _disposed;

        public ProductService(IRepository<Product> producrRepository)
        {
            _productRepository = producrRepository;
        }

        public IEnumerable<Product> GetAll()
        {

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
                    _productRepository.Dispose();
                }

                _disposed = true;
            }
        }
    }
}
