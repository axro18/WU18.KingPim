using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WU18.KingPim.Data.Models;
using WU18.KingPim.Entities.Repositories;
using WU18.KingPim.Entities.ViewModels;

namespace WU18.KingPim.Web.Controllers.Home
{
    public class HomeController : Controller
    {
        //private readonly IProductRepository _repo;
        //private readonly IMapper _mapper;
        //public HomeController(IProductRepository productRepository, IMapper mapper)
        //{

        //    _repo = productRepository;
        //    _mapper = mapper;
        //}
        //public IActionResult Index()
        //{
        //    var data = new HomeViewModel();
        //    data.Products = _mapper.Map<IEnumerable<ProductViewModel>>(_repo);
        //    data.Categories = _mapper.Map<IEnumerable<CategoryViewModel>>(_repo);
        //    data.SubCategories = _mapper.Map<IEnumerable<SubCategoryViewModel>>(_repo);
        //    //var data = _repo.Products.Select(x => _mapper.Map<Product, ProductViewModel>(x)) + _repo.SubCategories.Select(e => _mapper.Map<SubCategory, Sub>);
        //    return View(data);
        //}
    }
}