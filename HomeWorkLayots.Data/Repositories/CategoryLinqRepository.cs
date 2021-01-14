using System;
using System.Collections.Generic;
using System.Text;
using HomeWorkLayots.Data.Interfaces;
using HomeWorkLayots.Data.Model;
using System.Data.Linq;
using System.Linq;

namespace HomeWorkLayots.Data.Repositories
{
    public class CategoryLinqRepository : ICategoryRepository
    {
        private string _connectionString = @"Data Source=LAPTOP-06F37EVB;Initial Catalog=HomeWork4;Integrated Security=True";

        public IEnumerable<Category> GetCategories()
        {
            DataContext db = new DataContext(_connectionString);
            var result = new List<Category>();
            result = db.GetTable<Category>().ToList();
            return result;
        }
    }
}
