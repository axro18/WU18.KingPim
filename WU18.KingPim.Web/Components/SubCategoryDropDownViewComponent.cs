using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WU18.KingPim.Entities.Services.Interfaces;
using WU18.KingPim.Entities.ViewModels;

namespace WU18.KingPim.Web.Components
{
    public class SubCategoryDropDownViewComponent : ViewComponent
    {
        private readonly ISubCategoryService _subCategoryService;
        private readonly IMapper _mapper;
        public SubCategoryDropDownViewComponent(ISubCategoryService subCategoryService, IMapper mapper)
        {
            _subCategoryService = subCategoryService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync(int selectedSubCategoryId)
            {
            IEnumerable<SubCategoryViewModel> items = _subCategoryService.GetAll();
            
            var viewmodel = new SubCategoryViewModel()
            {
                SubCategorySelectList =
                    _mapper.Map<IEnumerable<SubCategoryViewModel>, IEnumerable<SelectListItem>>(items)
            };
            viewmodel.SelectedSubCategoryId = selectedSubCategoryId;
            return View(viewmodel);
        }
    }
}