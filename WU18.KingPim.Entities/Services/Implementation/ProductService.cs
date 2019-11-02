using System.Collections.Generic;
using AutoMapper;
using WU18.KingPim.Entities.Repositories;
using WU18.KingPim.Entities.Services.Interfaces;
using WU18.KingPim.Entities.ViewModels;

namespace WU18.KingPim.Entities.Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public IEnumerable<ProductViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<ProductViewModel>>(_productRepository.GetProducts());
        }
    }
}