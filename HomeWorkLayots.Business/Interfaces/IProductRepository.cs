using System;
using System.Collections.Generic;
using HomeWorkLayots.Business.Models;

namespace HomeWorkLayots.Business.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetProductsByCategory(int categoryId);
        List<Product> GetFirstCategoryProducts();
    }
}
