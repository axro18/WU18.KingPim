using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Internal;
using WU18.KingPim.Data.Models;

namespace WU18.KingPim.Data.DataAccess
{
    public static class Seeder
    {
        public static void FillDbIfEmpty(KingPimContext ctx)
        {

            if (!ctx.SubCategories.Any())
            {
                ctx.SubCategories.Add(new SubCategory
                {
                    Name = "Nvidia",
                });
                ctx.SaveChanges();
            }

            if (!ctx.Categories.Any())
            {
                ctx.Categories.Add(new Category
                {

                    Name = "Grafikkort",
                    SubCategoryId = 1

                });
                ctx.SaveChanges();
            }

            if (!ctx.Products.Any())
            {
                ctx.Products.Add(new Product
                {
                    ArtNumber = 1001,
                    CampaignPrice = 1.2m,
                    CreatedDate = DateTime.Now,
                    Discontinued = false,
                    EndCampaign = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    Name = "Geforce RTX 2080",
                    PackageDepth = 340,
                    PackageHeight = 250,
                    PackageWidth = 340,
                    PackageWeight = 2000,
                    Publish = true,
                    PriceExVat = 8000,
                    StartCampaign = DateTime.Now,
                    StockBalance = 30,
                    SubCategoryId = null
                });
                ctx.SaveChanges();
            }


        }
    }
}
