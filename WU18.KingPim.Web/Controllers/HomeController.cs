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
        //private SubCategory _subCategory;
        public HomeController(IProductService productService)
        {
            _productService = productService;
            //_subCategory = new SubCategory();
        }

        [HttpPost]
        public IActionResult AddProduct(ProductViewModel productViewModel)
        {
            //TODO Try Catch
            _productService.AddItem(productViewModel);
            return Ok();
        }

        public IActionResult Index()
        {
            //_subCategory = new SubCategory();
            return View(_productService.GetAll());
        }
    }
}