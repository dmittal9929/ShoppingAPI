using ProjectShopping.DbContexts;
using ProjectShopping.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectShopping.services
{
    public class ShoppingRepository : IShoppingRepository
    {
        private readonly ShopingDbContext _context;
        public ShoppingRepository(ShopingDbContext dbContext)
        {
            _context = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
        public IEnumerable<Product> GetProducts()
        {
            return _context.products.ToList();
        }

        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            product.PID = new Guid();
            foreach (var tag in product.TagList)
            {
                tag.PID = product.PID;  
            }



            
            _context.Add(product);
        }

        public bool save()
        {
            return (_context.SaveChanges() > 0);
        }
    }
}
