﻿// <auto-generated />
using System;
using BethanysPieShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BethanysPieShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BethanysPieShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Fruit pies",
                            Description = "All-fruit pies"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Chese cake",
                            Description = "Cheese all the way"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Seasonal pies",
                            Description = "Get in the mood for a seasonal pie"
                        });
                });

            modelBuilder.Entity("BethanysPieShop.Models.Pie", b =>
                {
                    b.Property<int>("PieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AllergyInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CotegoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPieOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Pies");

                    b.HasData(
                        new
                        {
                            PieId = 1,
                            AllergyInformation = "",
                            CotegoryId = 1,
                            ImageThumbnailUrl = "",
                            ImageUrl = "/images/cheesecake1.png",
                            InStock = true,
                            IsPieOfTheWeek = false,
                            LongDescription = "default description",
                            Name = "Strawberry pie",
                            Price = 15.95m,
                            ShortDescription = "yummy"
                        },
                        new
                        {
                            PieId = 2,
                            AllergyInformation = "",
                            CotegoryId = 2,
                            ImageThumbnailUrl = "",
                            ImageUrl = "/images/cheesecake2.png",
                            InStock = true,
                            IsPieOfTheWeek = true,
                            LongDescription = "default description",
                            Name = "Chese cake",
                            Price = 30.95m,
                            ShortDescription = "delicious"
                        },
                        new
                        {
                            PieId = 3,
                            AllergyInformation = "",
                            CotegoryId = 3,
                            ImageThumbnailUrl = "",
                            ImageUrl = "/images/cheesecake3.png",
                            InStock = true,
                            IsPieOfTheWeek = true,
                            LongDescription = "default description",
                            Name = "Rhubarb Pie",
                            Price = 10.95m,
                            ShortDescription = "savory"
                        },
                        new
                        {
                            PieId = 4,
                            AllergyInformation = "",
                            CotegoryId = 1,
                            ImageThumbnailUrl = "",
                            ImageUrl = "/images/cheesecake4.png",
                            InStock = true,
                            IsPieOfTheWeek = true,
                            LongDescription = "default description",
                            Name = "Pumpking pie",
                            Price = 12.95m,
                            ShortDescription = "tasty"
                        });
                });

            modelBuilder.Entity("BethanysPieShop.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("PieId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PieId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("BethanysPieShop.Models.Pie", b =>
                {
                    b.HasOne("BethanysPieShop.Models.Category", "Category")
                        .WithMany("Pies")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("BethanysPieShop.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("BethanysPieShop.Models.Pie", "Pie")
                        .WithMany()
                        .HasForeignKey("PieId");
                });
#pragma warning restore 612, 618
        }
    }
}
