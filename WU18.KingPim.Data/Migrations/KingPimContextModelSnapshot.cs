﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WU18.KingPim.Data.DataAccess;

namespace WU18.KingPim.Data.Migrations
{
    [DbContext(typeof(KingPimContext))]
    partial class KingPimContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WU18.KingPim.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WU18.KingPim.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtNumber");

                    b.Property<decimal>("CampaignPrice");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<bool>("Discontinued");

                    b.Property<DateTime?>("EndCampaign");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<int>("PackageDepth");

                    b.Property<int>("PackageHeight");

                    b.Property<int>("PackageWeight");

                    b.Property<int>("PackageWidth");

                    b.Property<decimal>("PriceExVat");

                    b.Property<bool>("Publish");

                    b.Property<DateTime?>("StartCampaign");

                    b.Property<int>("StockBalance");

                    b.Property<int>("SubCategoryId");

                    b.HasKey("Id");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WU18.KingPim.Data.Models.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("WU18.KingPim.Data.Models.Product", b =>
                {
                    b.HasOne("WU18.KingPim.Data.Models.SubCategory", "SubCategory")
                        .WithMany("Products")
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WU18.KingPim.Data.Models.SubCategory", b =>
                {
                    b.HasOne("WU18.KingPim.Data.Models.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
