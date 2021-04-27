using ProjectShopping.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectShopping.services
{
    public interface IShoppingRepository
    {
        IEnumerable<Product> GetProducts();

        void AddProduct(Product product);

        bool save();
    }
}
