using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WU18.KingPim.Data.DataAccess;
using WU18.KingPim.Data.Models;

namespace WU18.KingPim.Entities.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly KingPimContext ctx;

        public ProductRepository(KingPimContext context)
        {
            this.ctx = context;
        }

        public IEnumerable<Product> Products => ctx.Products;

        //public IEnumerable<Product> GetProductsFromSubCategories(KingPimContext ctx)
        //{
        //    var p = ctx.Products.Include("SubCategory");
        //    return ctx.Products.Where(x => x.Id == )
        //}
    }
}
