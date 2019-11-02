using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using WU18.KingPim.Data.DataAccess;
using WU18.KingPim.Data.Models;

namespace WU18.KingPim.Entities.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {

        public ProductRepository(KingPimContext ctx) : base(ctx) { }

        public IEnumerable<Product> GetProducts()
        {
            return FindAll(); // FindAll() from generic repository
        }


        //public IEnumerable<Product> GetProductsFromSubCategories(KingPimContext ctx)
        //{
        //    var p = ctx.Products.Include("SubCategory");
        //    return ctx.Products.Where(x => x.Id == )
        //}
    }
}
