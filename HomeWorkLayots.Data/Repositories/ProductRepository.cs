using HomeWorkLayots.Business.Interfaces;
using HomeWorkLayots.Business.Models;
using System.Collections.Generic;
using System.Linq;

namespace HomeWorkLayots.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext db;

        public ProductRepository(StoreContext context)
        {
            db = context;
        }

        public List<Product> GetFirstCategoryProducts()
        {
            var result = from product in db.Products
                where product.Categories.Any(c => c.ID == 1)
                select product;
            return result.ToList();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            var result = from product in db.Products
                where product.Categories.Any(c => c.ID == categoryId)
                select product;
            return result.ToList();
        }
    }
}
