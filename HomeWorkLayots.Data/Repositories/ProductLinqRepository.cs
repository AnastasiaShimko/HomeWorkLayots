using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using HomeWorkLayots.Data.Interfaces;
using HomeWorkLayots.Data.Model;

namespace HomeWorkLayots.Data.Repositories
{
    public class ProductLinqRepository : IProductRepository
    {
        private string _connectionString = @"Data Source=LAPTOP-06F37EVB;Initial Catalog=HomeWork4;Integrated Security=True";

        public List<Product> GetCategoryProducts(int categoryid)
        {
            DataContext db = new DataContext(_connectionString);
            var result = new List<Product>();
            //var productList = new List<int>();
            var productList = db.GetTable<CategoryProduct>().Where(p => p.CategoryID == categoryid).Select(s => s.GoodID).ToArray();
            result = db.GetTable<Product>().Where(p => productList.Contains(p.ID)).ToList();
            return result;
        }
    }
}
