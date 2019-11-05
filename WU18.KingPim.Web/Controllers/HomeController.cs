using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WU18.KingPim.Data.Models;
using WU18.KingPim.Entities.Services.Interfaces;
using WU18.KingPim.Entities.ViewModels;

namespace WU18.KingPim.Web.Controllers.Home
{

    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetProductById(int id)
        {
           return View("Product", _productService.FindById(id));
        }

        [HttpPost]
        public IActionResult RemoveProduct(int id)
        {
            _productService.DeleteItem(id);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult AddProduct(ProductViewModel productViewModel)
        {
            //TODO Try Catch
            productViewModel.CreatedDate = DateTime.Now;
            _productService.AddItem(productViewModel);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Index()
        {
            return View(_productService.GetAll());
        }
    }
}