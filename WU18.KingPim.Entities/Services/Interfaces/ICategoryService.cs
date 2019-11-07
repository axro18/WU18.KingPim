using System.Collections.Generic;
using WU18.KingPim.Entities.ViewModels;

namespace WU18.KingPim.Entities.Services.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<CategoryViewModel> GetAll();
        void AddItem(CategoryViewModel categoryViewModel);
        void DeleteItem(int id);
        CategoryViewModel FindById(int id);
        void EditItem(CategoryViewModel categoryViewModel);
    }
}