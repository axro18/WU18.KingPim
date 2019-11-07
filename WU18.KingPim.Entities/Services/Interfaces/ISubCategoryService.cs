using System.Collections.Generic;
using WU18.KingPim.Entities.ViewModels;

namespace WU18.KingPim.Entities.Services.Interfaces
{
    public interface ISubCategoryService
    {
        IEnumerable<SubCategoryViewModel> GetAll();
        void AddItem(SubCategoryViewModel subCategoryViewModel);
        void DeleteItem(int id);
        SubCategoryViewModel FindById(int id);
        void EditItem(SubCategoryViewModel subCategoryViewModel);
    }
}