using System.Collections.Generic;
using DataAcess.Entities;

namespace BusinessLogic.Interfaces
{
    public interface IManageService
    {
        IEnumerable<Store> GetAllStores();

        IEnumerable<Product> GetAllProducts();

        IEnumerable<Product> GetProductsByStoreId(int storeId);
    }
}
