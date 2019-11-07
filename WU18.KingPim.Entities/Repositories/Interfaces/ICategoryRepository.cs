using System.Collections.Generic;
using WU18.KingPim.Data.Models;

namespace WU18.KingPim.Entities.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
        void AddCategory(Category category);
        Category FindCategoryById(int id);
        void RemoveCategory(int id);
        void EditCategory(Category category);
    }
}