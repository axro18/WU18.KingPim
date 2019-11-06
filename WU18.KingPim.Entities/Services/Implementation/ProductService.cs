using System.Collections.Generic;
using AutoMapper;
using WU18.KingPim.Data.Models;
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

        public void AddItem(ProductViewModel productViewModel)
        {
            _productRepository.AddProduct(_mapper.Map<Product>(productViewModel));
        }

        public void DeleteItem(int id)
        {
            var entity = FindById(id);
            _productRepository.RemoveProduct(entity.Id);
        }

        public ProductViewModel FindById(int id)
        {
            return _mapper.Map<ProductViewModel>(_productRepository.FindProductById(id));
        }

        public void EditItem(ProductViewModel productViewModel)
        {
            _productRepository.EditProduct(_mapper.Map<Product>(productViewModel));
        }
    }
}