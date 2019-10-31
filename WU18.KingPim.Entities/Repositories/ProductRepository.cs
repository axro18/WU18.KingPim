using System;
using System.Collections.Generic;
using System.Text;
using WU18.KingPim.Data.DataAccess;
using WU18.KingPim.Data.Models;

namespace WU18.KingPim.Entities.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private KingPimContext ctx;

        public ProductRepository(KingPimContext context)
        {
            this.ctx = context;
        }

        public IEnumerable<Product> Products => ctx.Products;
    }
}
