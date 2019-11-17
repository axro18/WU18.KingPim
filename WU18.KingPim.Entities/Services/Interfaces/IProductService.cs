using System.Collections.Generic;
using WU18.KingPim.Entities.ViewModels;

namespace WU18.KingPim.Entities.Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductViewModel> GetAll();
        void AddItem(ProductViewModel productViewModel);
        void DeleteItem(int id);
        ProductViewModel FindById(int id);
        void EditItem(ProductViewModel productViewModel);
    }
}