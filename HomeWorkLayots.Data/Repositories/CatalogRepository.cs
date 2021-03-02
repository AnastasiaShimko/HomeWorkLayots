using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HomeWorkLayots.Business.Interfaces;
using HomeWorkLayots.Business.Model;

namespace HomeWorkLayots.Data.Repositories
{
    public class CatalogRepository : ICatalogRepository
    {
        StoreContext db;

        public List<Category> GetCategories()
        {
            return db.Categories.ToList();
        }
    }
}
