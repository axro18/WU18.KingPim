using System.Collections.Generic;
using AutoMapper;
using WU18.KingPim.Data.Models;
using WU18.KingPim.Entities.Repositories;
using WU18.KingPim.Entities.Services.Interfaces;
using WU18.KingPim.Entities.ViewModels;

namespace WU18.KingPim.Entities.Services.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public IEnumerable<CategoryViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<CategoryViewModel>>(_categoryRepository.GetCategories());
        }

        public void AddItem(CategoryViewModel categoryViewModel)
        {
            _categoryRepository.AddCategory(_mapper.Map<Category>(categoryViewModel));
        }

        public void DeleteItem(int id)
        {
            var entity = FindById(id);
            _categoryRepository.RemoveCategory(entity.Id);
        }

        public CategoryViewModel FindById(int id)
        {
            return _mapper.Map<CategoryViewModel>(_categoryRepository.FindCategoryById(id));
        }

        public void EditItem(CategoryViewModel categoryViewModel)
        {
            _categoryRepository.EditCategory(_mapper.Map<Category>(categoryViewModel));
        }
    }
}