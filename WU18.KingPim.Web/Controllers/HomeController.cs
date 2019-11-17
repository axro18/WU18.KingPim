using Microsoft.AspNetCore.Mvc;
using WU18.KingPim.Entities.Services.Interfaces;

namespace WU18.KingPim.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View(_productService.GetAll());
        }
    }
}