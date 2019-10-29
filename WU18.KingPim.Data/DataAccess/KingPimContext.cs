﻿using Microsoft.EntityFrameworkCore;
using WU18.KingPim.Data.Models;

namespace WU18.KingPim.Data.DataAccess
{
    public class KingPimContext : DbContext
    {
        public KingPimContext(DbContextOptions<KingPimContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}