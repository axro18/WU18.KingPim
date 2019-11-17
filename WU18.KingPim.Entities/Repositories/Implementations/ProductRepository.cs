using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WU18.KingPim.Data.DataAccess;
using WU18.KingPim.Data.Models;

namespace WU18.KingPim.Entities.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {

        public ProductRepository(KingPimContext ctx) : base(ctx) { }
        public IEnumerable<Product> GetProducts()
        {
            return FindAll().Include("SubCategory");
        }

        public void AddProduct(Product product)
        {
            AddItem(product);
        }

        public Product FindProductById(int id)
        {
            return FindById(id);
        }

        public void RemoveProduct(int id)
        {
            RemoveItem(id);
        }

        public void EditProduct(Product product)
        {
            EditItem(product);
        }
    }
}
