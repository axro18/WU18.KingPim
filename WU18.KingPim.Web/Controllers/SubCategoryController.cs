using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WU18.KingPim.Entities.Services.Interfaces;
using WU18.KingPim.Entities.ViewModels;

namespace WU18.KingPim.Web.Controllers
{
    public class SubCategoryController : Controller
    {
        private readonly ISubCategoryService _subCategoryService;

        public SubCategoryController(ISubCategoryService subCategoryService)
        {
            _subCategoryService = subCategoryService;
        }
        [HttpGet]
        public IActionResult GetSubCategoryById(int id)
        {
            return View("CreateSubCategory", _subCategoryService.FindById(id));
        }
        [HttpPost]
        public IActionResult AddSubCategory(SubCategoryViewModel subCategoryViewModel)
        {
            //TODO Try Catch
            _subCategoryService.AddItem(subCategoryViewModel);
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult EditSubCategory(SubCategoryViewModel subCategoryViewModel)
        {
            _subCategoryService.EditItem(subCategoryViewModel);
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult RemoveSubCategory(int id)
        {
            _subCategoryService.DeleteItem(id);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}