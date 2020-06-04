using System;
using System.Collections.Generic;
using BusinessLogic.Exceptions;
using BusinessLogic.Interfaces;
using DataAcess.Entitites;
using DataAcess.Interfaces;

namespace BusinessLogic.Services
{
    public class ManageService : IManageService, IDisposable
    {
        private readonly IRepository<Store> _storeRepository;
        private readonly IRepository<Product> _productRepository;
        private bool _disposed;

        public ManageService(IRepository<Store> storeRepository, IRepository<Product> productRepository)
        {
            _storeRepository = storeRepository;
            _productRepository = productRepository;
        }

        public IEnumerable<Store> GetAllStores()
        {
            var stores = _storeRepository.All();
            if (stores == null)
            {
                throw new StoreException("stores not found");
            }

            return stores;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var products = _productRepository.All();

            if (products == null)
            {
                throw new ProductException("products not found");
            }

            return products;
        }

        public IEnumerable<Product> GetProductsByStoreId(int storeId)
        {
            var allProducts = _productRepository.All();

            if (allProducts == null)
            {
                throw new ProductException("products not found");
            }

            List<Product> foundProducts = new List<Product>();

            foreach (Product product in allProducts)
            {
                if (product.StoreId == storeId)
                {
                    foundProducts.Add(product);
                }
            }

            if (foundProducts == null)
            {
                throw new ProductException("products with current storeId not found");
            }

            return foundProducts;
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
                    _storeRepository.Dispose();
                }

                _disposed = true;
            }
        }
    }
}
