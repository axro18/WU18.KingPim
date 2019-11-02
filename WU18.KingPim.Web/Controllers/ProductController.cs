using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WU18.KingPim.Data.Models;
using WU18.KingPim.Entities.Repositories;
using WU18.KingPim.Entities.ViewModels;

namespace WU18.KingPim.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repo;
        private readonly ICategoryRepository _category;
        private readonly ISubCategoryRepository _subCategory;
        private readonly IMapper _mapper;
        public ProductController(IProductRepository productRepository, IMapper mapper, ICategoryRepository categoryRepository, ISubCategoryRepository subCategoryRepository)
        {
            _category = categoryRepository;
            _subCategory = subCategoryRepository;
            _repo = productRepository;
            _mapper = mapper;
        }

        public IActionResult List()
        {
            //var productViewModel = new ProductViewModel();
            //productViewModel.Categories = _mapper.Map<IEnumerable<CategoryViewModel>>(_category);
            //productViewModel.SubCategories = _mapper.Map<IEnumerable<SubCategoryViewModel>>(_subCategory);
            ////var data = _repo.Products.Select(x => _mapper.Map<Product, ProductViewModel>(x));
            return View(/*productViewModel*/);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}