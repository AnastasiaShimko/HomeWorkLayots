using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWorkLayots.Data.Model;

namespace HomeWorkLayots.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
    }
}
