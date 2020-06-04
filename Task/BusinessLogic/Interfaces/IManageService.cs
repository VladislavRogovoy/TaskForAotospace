using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess.Entitites;

namespace BusinessLogic.Interfaces
{
    public interface IManageService
    {
        IEnumerable<Store> GetAllStores();

        IEnumerable<Product> GetAllProducts();

        IEnumerable<Product> GetProductsByStoreId(int storeId);
    }
}
