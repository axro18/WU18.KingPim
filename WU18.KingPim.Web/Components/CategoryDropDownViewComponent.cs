using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WU18.KingPim.Entities.Services.Interfaces;
using WU18.KingPim.Entities.ViewModels;

namespace WU18.KingPim.Web.Components
{
    public class CategoryDropDownViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryDropDownViewComponent(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync(int selectedCategoryId)
        {
            IEnumerable<CategoryViewModel> items = _categoryService.GetAll();
            var viewModel = new CategoryViewModel()
            {
                CategorySelectList =
                    _mapper.Map<IEnumerable<CategoryViewModel>, IEnumerable<SelectListItem>>(items)
            };
            return View(viewModel);
        }
    }
}