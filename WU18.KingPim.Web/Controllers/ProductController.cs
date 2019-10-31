using Microsoft.AspNetCore.Mvc;
using WU18.KingPim.Entities.Repositories;

namespace WU18.KingPim.Web.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repo;

        public ProductController(IProductRepository productRepository)
        {
            repo = productRepository;
        }

        public IActionResult List()
        {
            return View(repo.Products);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}