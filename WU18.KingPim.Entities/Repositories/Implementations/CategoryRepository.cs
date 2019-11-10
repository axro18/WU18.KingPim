using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WU18.KingPim.Data.DataAccess;
using WU18.KingPim.Data.Models;

namespace WU18.KingPim.Entities.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(KingPimContext ctx) : base(ctx) { }
        public IEnumerable<Category> GetCategories()
        {
            return FindAll();
        }

        public void AddCategory(Category category)
        {
            AddItem(category);
        }

        public Category FindCategoryById(int id)
        {
            return FindById(id);
        }

        public void RemoveCategory(int id)
        {
            RemoveItem(id);
        }

        public void EditCategory(Category category)
        {
            EditItem(category);
        }
    }
}