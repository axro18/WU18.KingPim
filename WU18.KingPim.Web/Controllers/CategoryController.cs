using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WU18.KingPim.Entities.Services.Interfaces;
using WU18.KingPim.Entities.ViewModels;

namespace WU18.KingPim.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public IActionResult GetCategoryById(int id)
        {
            return View("CreateCategory", _categoryService.FindById(id));
        }
        [HttpPost]
        public IActionResult AddCategory(CategoryViewModel categoryViewModel)
        {
            //TODO Try Catch
            _categoryService.AddItem(categoryViewModel);
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult EditCategory(CategoryViewModel categoryViewModel)
        {
            _categoryService.EditItem(categoryViewModel);
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult RemoveCategory(int id)
        {
            _categoryService.DeleteItem(id);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Index()
        {
            return View(_categoryService.GetAll());
        }
    }
}