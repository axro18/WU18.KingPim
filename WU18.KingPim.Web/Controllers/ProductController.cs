using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using WU18.KingPim.Entities.Services.Interfaces;
using WU18.KingPim.Entities.ViewModels;

namespace WU18.KingPim.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult GetProductById(int id)
        {
            return View("EditProduct", _productService.FindById(id));
        }
        [HttpPost]
        public IActionResult AddProduct(ProductViewModel productViewModel)
        {
            //TODO Try Catch
            productViewModel.CreatedDate = DateTime.Now;
            _productService.AddItem(productViewModel);
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult EditProduct(ProductViewModel productViewModel)
        {
            productViewModel.ModifiedDate = DateTime.Now;
            _productService.EditItem(productViewModel);
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult RemoveProduct(int id)
        {
            _productService.DeleteItem(id);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult CreateProduct()
        {
            var viewmodel = new ProductViewModel();
            return View(viewmodel);
        }

        public IActionResult Products()
        {
            return View(_productService.GetAll());
        }
    }
}