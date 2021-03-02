using System;
using System.Collections.Generic;
using System.Text;
using HomeWorkLayots.Business.Model;

namespace HomeWorkLayots.Business.Interfaces
{
    public interface ICatalogRepository
    {
        List<Category> GetCategories();
    }
}
