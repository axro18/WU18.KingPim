using System.Collections.Generic;
using WU18.KingPim.Data.Models;

namespace WU18.KingPim.Entities.Repositories
{
    public interface ISubCategoryRepository
    {
        IEnumerable<SubCategory> GetSubCategories();
        void AddSubCategory(SubCategory subCategory);
        SubCategory FindSubCategoryById(int id);
        void RemoveSubCategory(int id);
        void EditSubCategory(SubCategory subCategory);
    }
}