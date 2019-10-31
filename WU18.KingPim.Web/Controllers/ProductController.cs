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
        private readonly IMapper _mapper;
        public ProductController(IProductRepository productRepository, IMapper mapper)
        {
            _repo = productRepository;
            _mapper = mapper;
        }

        public IActionResult List()
        {
            var data = _repo.Products.Select(x => _mapper.Map<Product, ProductViewModel>(x));
            return View(data);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}