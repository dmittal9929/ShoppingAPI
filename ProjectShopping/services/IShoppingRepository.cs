using ProjectShopping.Entities;
using ProjectShopping.Models;
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

        Product GetProduct(Guid id);
        IEnumerable<User> GetAllUsers();
        public IEnumerable<Product> GetProducts(String gender);
        bool AddUser(User user);
        bool validateUser(UserLoginDTO user);
        public bool validateUserAdmin(UserLoginDTO user);

        void UpdateProduct();

        void AddOrder(Order order,Guid uid);
        IEnumerable<Order> GetOrders(Guid  uid);
        bool save();
    }
}
