using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WU18.KingPim.Data.DataAccess;
using WU18.KingPim.Data.Models;

namespace WU18.KingPim.Entities.Repositories
{
    public class SubcategoryRepository : GenericRepository<SubCategory>, ISubCategoryRepository
    {
        public SubcategoryRepository(KingPimContext ctx) : base(ctx) { }
        public IEnumerable<SubCategory> GetSubCategories()
        {
            return FindAll().Include("Category").Include("Product");
        }

        public void AddSubCategory(SubCategory subCategory)
        {
            AddItem(subCategory);
        }

        public SubCategory FindSubCategoryById(int id)
        {
            return FindById(id);
        }

        public void RemoveSubCategory(int id)
        {
            RemoveItem(id);
        }

        public void EditSubCategory(SubCategory subCategory)
        {
            EditItem(subCategory);
        }
    }
}