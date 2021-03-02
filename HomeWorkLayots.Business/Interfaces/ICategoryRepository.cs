using System.Collections.Generic;
using HomeWorkLayots.Business.Models;

namespace HomeWorkLayots.Business.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategories();
        string GetFirstCategoryName();
    }
}
