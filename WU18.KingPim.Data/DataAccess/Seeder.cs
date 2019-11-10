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


            if (!ctx.Categories.Any())
            {
                ctx.Categories.Add(new Category
                {
                    Name = "Grafikkort"
                });ctx.Categories.Add(new Category
                {
                    Name = "Internminne"
                });ctx.Categories.Add(new Category
                {
                    Name = "Hårddiskar"
                });ctx.Categories.Add(new Category
                {
                    Name = "Processor"
                });ctx.Categories.Add(new Category
                {
                    Name = "Moderkort"
                });
                ctx.SaveChanges();
            }
            if (!ctx.SubCategories.Any())
            {
                ctx.SubCategories.Add(new SubCategory
                {
                    Name = "Nvidia",
                    CategoryId = 1
                });ctx.SubCategories.Add(new SubCategory
                {
                    Name = "AMD",
                    CategoryId = 1
                });ctx.SubCategories.Add(new SubCategory
                {
                    Name = "DDR3",
                    CategoryId = 2
                });ctx.SubCategories.Add(new SubCategory
                {
                    Name = "DDR4",
                    CategoryId = 2
                });ctx.SubCategories.Add(new SubCategory
                {
                    Name = "Mekanisk",
                    CategoryId = 3
                });ctx.SubCategories.Add(new SubCategory
                {
                    Name = "SSD",
                    CategoryId = 3
                });ctx.SubCategories.Add(new SubCategory
                {
                    Name = "Intel",
                    CategoryId = 4
                });ctx.SubCategories.Add(new SubCategory
                {
                    Name = "AMD",
                    CategoryId = 4
                });ctx.SubCategories.Add(new SubCategory
                {
                    Name = "Socket AM4",
                    CategoryId = 5
                });ctx.SubCategories.Add(new SubCategory
                {
                    Name = "Socket 1151 v2",
                    CategoryId = 5
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
                    SubCategoryId = 1
                });ctx.Products.Add(new Product
                {
                    ArtNumber = 1002,
                    CampaignPrice = 1.2m,
                    CreatedDate = DateTime.Now,
                    Discontinued = true,
                    EndCampaign = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    Name = "Geforce RTX 2060",
                    PackageDepth = 340,
                    PackageHeight = 250,
                    PackageWidth = 340,
                    PackageWeight = 2000,
                    Publish = true,
                    PriceExVat = 6000,
                    StartCampaign = DateTime.Now,
                    StockBalance = 30,
                    SubCategoryId = 1
                });ctx.Products.Add(new Product
                {
                    ArtNumber = 1003,
                    CampaignPrice = 1.2m,
                    CreatedDate = DateTime.Now,
                    Discontinued = false,
                    EndCampaign = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    Name = "Geforce RTX 2070 Super",
                    PackageDepth = 340,
                    PackageHeight = 250,
                    PackageWidth = 340,
                    PackageWeight = 2000,
                    Publish = true,
                    PriceExVat = 8000,
                    StartCampaign = DateTime.Now,
                    StockBalance = 30,
                    SubCategoryId = 1
                });ctx.Products.Add(new Product
                {
                    ArtNumber = 1101,
                    CampaignPrice = 1.2m,
                    CreatedDate = DateTime.Now,
                    Discontinued = false,
                    EndCampaign = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    Name = "Sapphire RX 5700XT",
                    PackageDepth = 430,
                    PackageHeight = 90,
                    PackageWidth = 240,
                    PackageWeight = 1667,
                    Publish = true,
                    PriceExVat = 3200,
                    StartCampaign = DateTime.Now,
                    StockBalance = 20,
                    SubCategoryId = 2
                });ctx.Products.Add(new Product
                {
                    ArtNumber = 1102,
                    CampaignPrice = 1.2m,
                    CreatedDate = DateTime.Now,
                    Discontinued = false,
                    EndCampaign = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    Name = "Gigabyte RX 5700XT",
                    PackageDepth = 398,
                    PackageHeight = 230,
                    PackageWidth = 85,
                    PackageWeight = 1596,
                    Publish = true,
                    PriceExVat = 4132,
                    StartCampaign = DateTime.Now,
                    StockBalance = 30,
                    SubCategoryId = 2
                });ctx.Products.Add(new Product
                {
                    ArtNumber = 2001,
                    CampaignPrice = 1.2m,
                    CreatedDate = DateTime.Now,
                    Discontinued = false,
                    EndCampaign = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    Name = "16gb DDR3 CL10",
                    PackageDepth = 145,
                    PackageHeight = 15,
                    PackageWidth = 93,
                    PackageWeight = 95,
                    Publish = true,
                    PriceExVat = 520,
                    StartCampaign = DateTime.Now,
                    StockBalance = 30,
                    SubCategoryId = 3
                });ctx.Products.Add(new Product
                {
                    ArtNumber = 2101,
                    CampaignPrice = 1.2m,
                    CreatedDate = DateTime.Now,
                    Discontinued = false,
                    EndCampaign = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    Name = "256gb DDR4 CL16",
                    PackageDepth = 10,
                    PackageHeight = 90,
                    PackageWidth = 154,
                    PackageWeight = 397,
                    Publish = true,
                    PriceExVat = 12000,
                    StartCampaign = DateTime.Now,
                    StockBalance = 30,
                    SubCategoryId = 4
                });ctx.Products.Add(new Product
                {
                    ArtNumber = 3001,
                    CampaignPrice = 1.2m,
                    CreatedDate = DateTime.Now,
                    Discontinued = false,
                    EndCampaign = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    Name = "WD Gold 14TB 7200rpm",
                    PackageDepth = 130,
                    PackageHeight = 90,
                    PackageWidth = 210,
                    PackageWeight = 638,
                    Publish = true,
                    PriceExVat = 3200,
                    StartCampaign = DateTime.Now,
                    StockBalance = 10,
                    SubCategoryId = 5
                });ctx.Products.Add(new Product
                {
                    ArtNumber = 3002,
                    CampaignPrice = 1.2m,
                    CreatedDate = DateTime.Now,
                    Discontinued = false,
                    EndCampaign = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    Name = "WD Red Pro 12tb 7200rpm",
                    PackageDepth = 340,
                    PackageHeight = 250,
                    PackageWidth = 340,
                    PackageWeight = 620,
                    Publish = true,
                    PriceExVat = 3000,
                    StartCampaign = DateTime.Now,
                    StockBalance = 30,
                    SubCategoryId = 5
                });ctx.Products.Add(new Product
                {
                    ArtNumber = 3101,
                    CampaignPrice = 1.2m,
                    CreatedDate = DateTime.Now,
                    Discontinued = false,
                    EndCampaign = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    Name = "Samsung 860 PRO 4tb",
                    PackageDepth = 340,
                    PackageHeight = 250,
                    PackageWidth = 340,
                    PackageWeight = 620,
                    Publish = true,
                    PriceExVat = 6000,
                    StartCampaign = DateTime.Now,
                    StockBalance = 30,
                    SubCategoryId = 6
                });ctx.Products.Add(new Product
                {
                    ArtNumber = 4001,
                    CampaignPrice = 1.2m,
                    CreatedDate = DateTime.Now,
                    Discontinued = false,
                    EndCampaign = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    Name = "Intel Core i9 9900KS 4.0GHz",
                    PackageDepth = 340,
                    PackageHeight = 250,
                    PackageWidth = 340,
                    PackageWeight = 620,
                    Publish = true,
                    PriceExVat = 4000,
                    StartCampaign = DateTime.Now,
                    StockBalance = 30,
                    SubCategoryId = 7
                });ctx.Products.Add(new Product
                {
                    ArtNumber = 4002,
                    CampaignPrice = 1.2m,
                    CreatedDate = DateTime.Now,
                    Discontinued = false,
                    EndCampaign = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    Name = "Intel Core i9 9900KF 3.6GHz",
                    PackageDepth = 340,
                    PackageHeight = 250,
                    PackageWidth = 340,
                    PackageWeight = 620,
                    Publish = true,
                    PriceExVat = 3000,
                    StartCampaign = DateTime.Now,
                    StockBalance = 30,
                    SubCategoryId = 7
                });ctx.Products.Add(new Product
                {
                    ArtNumber = 4101,
                    CampaignPrice = 1.2m,
                    CreatedDate = DateTime.Now,
                    Discontinued = false,
                    EndCampaign = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    Name = "AMD Ryzen 9 3950X 3.5GHz",
                    PackageDepth = 340,
                    PackageHeight = 250,
                    PackageWidth = 340,
                    PackageWeight = 620,
                    Publish = true,
                    PriceExVat = 8000,
                    StartCampaign = DateTime.Now,
                    StockBalance = 30,
                    SubCategoryId = 8
                });ctx.Products.Add(new Product
                {
                    ArtNumber = 5001,
                    CampaignPrice = 1.2m,
                    CreatedDate = DateTime.Now,
                    Discontinued = false,
                    EndCampaign = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    Name = "Gigabyte x570 Aorus Xtreme",
                    PackageDepth = 340,
                    PackageHeight = 250,
                    PackageWidth = 340,
                    PackageWeight = 620,
                    Publish = true,
                    PriceExVat = 6000,
                    StartCampaign = DateTime.Now,
                    StockBalance = 30,
                    SubCategoryId = 9
                });ctx.Products.Add(new Product
                {
                    ArtNumber = 5101,
                    CampaignPrice = 1.2m,
                    CreatedDate = DateTime.Now,
                    Discontinued = false,
                    EndCampaign = null,
                    ModifiedDate = null,
                    ModifiedBy = null,
                    Name = "Gigabyte Z390 Aorus Xtreme",
                    PackageDepth = 340,
                    PackageHeight = 250,
                    PackageWidth = 340,
                    PackageWeight = 620,
                    Publish = true,
                    PriceExVat = 3000,
                    StartCampaign = DateTime.Now,
                    StockBalance = 30,
                    SubCategoryId = 10
                });
                ctx.SaveChanges();
            }


        }
    }
}
