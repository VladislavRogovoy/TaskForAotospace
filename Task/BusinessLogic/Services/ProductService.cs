using System;
using System.Collections.Generic;
using BusinessLogic.Exceptions;
using DataAcess.Entitites;
using DataAcess.Interfaces;

namespace BusinessLogic.Services
{
    public class ProductService : IDisposable
    {
        private readonly IRepository<Product> _productRepository;

        private bool _disposed;

        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetAll()
        {
            var products = _productRepository.All();

            if (products == null)
            {
                throw new ProductException("products not found");
            }

            return products;
        }

        public IEnumerable<Product> GetByStoreId(int storeId)
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
                }

                _disposed = true;
            }
        }
    }
}
