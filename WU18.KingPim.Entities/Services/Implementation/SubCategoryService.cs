using System.Collections.Generic;
using AutoMapper;
using WU18.KingPim.Data.Models;
using WU18.KingPim.Entities.Repositories;
using WU18.KingPim.Entities.Services.Interfaces;
using WU18.KingPim.Entities.ViewModels;

namespace WU18.KingPim.Entities.Services.Implementation
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly ISubCategoryRepository _subCategoryRepository;
        private readonly IMapper _mapper;

        public SubCategoryService(ISubCategoryRepository subCategoryRepository, IMapper mapper)
        {
            _subCategoryRepository = subCategoryRepository;
            _mapper = mapper;
        }

        public IEnumerable<SubCategoryViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<SubCategoryViewModel>>(_subCategoryRepository.GetSubCategories());
        }

        public void AddItem(SubCategoryViewModel subCategoryViewModel)
        {
            _subCategoryRepository.AddSubCategory(_mapper.Map<SubCategory>(subCategoryViewModel));
        }

        public void DeleteItem(int id)
        {
            var entity = FindById(id);
            _subCategoryRepository.RemoveSubCategory(entity.Id);
        }

        public SubCategoryViewModel FindById(int id)
        {
            return _mapper.Map<SubCategoryViewModel>(_subCategoryRepository.FindSubCategoryById(id));
        }

        public void EditItem(SubCategoryViewModel subCategoryViewModel)
        {
            _subCategoryRepository.EditSubCategory(_mapper.Map<SubCategory>(subCategoryViewModel));
        }
    }
}