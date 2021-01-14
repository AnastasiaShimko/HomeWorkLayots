using System;
using System.Collections.Generic;
using System.Text;
using HomeWorkLayots.Data.Model;

namespace HomeWorkLayots.Data.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetCategoryProducts(int categoryid);
    }
}
