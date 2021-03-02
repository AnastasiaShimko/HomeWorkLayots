using System.Collections.Generic;
using System.Linq;
using HomeWorkLayots.Business.Interfaces;
using HomeWorkLayots.Business.Models;

namespace HomeWorkLayots.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly StoreContext db;

        public CategoryRepository(StoreContext context)
        {
            db = context;
        }

        public List<Category> GetAllCategories()
        {
            var result = db.Categories.ToList();
            return result;
        }

        public string GetFirstCategoryName()
        {
            var result = db.Categories.First(c => c.ID == 1).Name;
            return result;
        }
    }
}
