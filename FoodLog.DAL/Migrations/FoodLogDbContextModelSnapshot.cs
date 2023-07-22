﻿// <auto-generated />
using System;
using FoodLog.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodLog.DAL.Migrations
{
    [DbContext(typeof(FoodLogDbContext))]
    partial class FoodLogDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.Property<Guid>("CategoriesGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductsGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CategoriesGuid", "ProductsGuid");

                    b.HasIndex("ProductsGuid");

                    b.ToTable("CategoryProduct");
                });

            modelBuilder.Entity("FoodLog.DAL.Entities.Category", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Guid = new Guid("993fe1e7-8946-4921-bac0-8fc1ec2c105d"),
                            Name = "Фрукты"
                        },
                        new
                        {
                            Guid = new Guid("fdec60f7-4d03-4a6b-b6cc-0ab4ba97d5cf"),
                            Name = "Сухофрукты"
                        },
                        new
                        {
                            Guid = new Guid("da829d2d-78da-4bca-9042-a1ba4bef34ac"),
                            Name = "Зелень / Овощи"
                        },
                        new
                        {
                            Guid = new Guid("a84c6fe9-a689-435b-b29d-ba3650e17102"),
                            Name = "Соки / Чай"
                        },
                        new
                        {
                            Guid = new Guid("1b769573-9e4d-441c-9b45-ebf11ed78752"),
                            Name = "Вода"
                        },
                        new
                        {
                            Guid = new Guid("5bed2328-662e-4430-963e-5d163919a4e5"),
                            Name = "Орехи / Злаки / Семена"
                        },
                        new
                        {
                            Guid = new Guid("26ceb232-1356-45c5-8fb7-43430bce3017"),
                            Name = "Термичка растительная"
                        },
                        new
                        {
                            Guid = new Guid("380b3515-1574-428b-86ea-f4b2ce929b49"),
                            Name = "Молочка"
                        },
                        new
                        {
                            Guid = new Guid("a5ac5444-8cb5-49ae-9e36-2b4c393df02d"),
                            Name = "Яйцо"
                        },
                        new
                        {
                            Guid = new Guid("38596f96-0db6-42c3-9a08-7dbf3ac42cb3"),
                            Name = "Рыба / Морепродукты"
                        },
                        new
                        {
                            Guid = new Guid("4a07ae8f-b1c4-4c7c-88b0-1d3444b72044"),
                            Name = "Мясо"
                        },
                        new
                        {
                            Guid = new Guid("b359abb3-e9f2-4937-a15e-784a637c91b9"),
                            Name = "Термичка на ПЖП"
                        },
                        new
                        {
                            Guid = new Guid("d6eb2e31-1767-4899-96a0-c9dd884d2b4f"),
                            Name = "Кофе"
                        },
                        new
                        {
                            Guid = new Guid("3391cf38-ad05-4447-b62e-308b6443154a"),
                            Name = "Кондитерка"
                        });
                });

            modelBuilder.Entity("FoodLog.DAL.Entities.Consumption", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Brutto")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Netto")
                        .HasColumnType("float");

                    b.Property<Guid>("ProductGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("TrashPercentage")
                        .HasColumnType("float");

                    b.Property<double>("TrashWeight")
                        .HasColumnType("float");

                    b.HasKey("Guid");

                    b.HasIndex("ProductGuid");

                    b.ToTable("Consumptions");
                });

            modelBuilder.Entity("FoodLog.DAL.Entities.Product", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Caloriers")
                        .HasColumnType("float");

                    b.Property<double>("Carb")
                        .HasColumnType("float");

                    b.Property<double>("Fat")
                        .HasColumnType("float");

                    b.Property<double>("HarmScore")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Prot")
                        .HasColumnType("float");

                    b.HasKey("Guid");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Guid = new Guid("acdd3326-7cd1-47d1-a181-bf13cd976a74"),
                            Caloriers = 52.0,
                            Carb = 11.4,
                            Fat = 0.40000000000000002,
                            HarmScore = 10.0,
                            Name = "Яблоко",
                            Prot = 0.29999999999999999
                        },
                        new
                        {
                            Guid = new Guid("ef16d6da-9a1b-487b-bfed-6226f82243f6"),
                            Caloriers = 576.0,
                            Carb = 6.0,
                            Fat = 49.0,
                            HarmScore = 20.0,
                            Name = "Миндаль",
                            Prot = 21.0
                        },
                        new
                        {
                            Guid = new Guid("9bcc4f3a-d20a-480a-aa63-23f1a298c515"),
                            Caloriers = 18.0,
                            Carb = 3.8999999999999999,
                            Fat = 0.20000000000000001,
                            HarmScore = 5.0,
                            Name = "Томат",
                            Prot = 0.90000000000000002
                        },
                        new
                        {
                            Guid = new Guid("9a12113b-b5e8-4ce5-bcba-f469bc62fb58"),
                            Caloriers = 59.0,
                            Carb = 4.7000000000000002,
                            Fat = 3.0,
                            HarmScore = 15.0,
                            Name = "Йогурт",
                            Prot = 3.5
                        },
                        new
                        {
                            Guid = new Guid("2b5db54e-5c2c-4dcc-bf0f-3d6bb5c59095"),
                            Caloriers = 208.0,
                            Carb = 0.0,
                            Fat = 14.300000000000001,
                            HarmScore = 25.0,
                            Name = "Лосось",
                            Prot = 20.0
                        },
                        new
                        {
                            Guid = new Guid("cd3a90bc-6cb8-4733-b15f-ce0401a08a89"),
                            Caloriers = 96.0,
                            Carb = 21.0,
                            Fat = 0.20000000000000001,
                            HarmScore = 10.0,
                            Name = "Банан",
                            Prot = 1.0
                        },
                        new
                        {
                            Guid = new Guid("45b6ae1a-0323-44bb-b110-0020e48d94cc"),
                            Caloriers = 43.0,
                            Carb = 8.1999999999999993,
                            Fat = 0.20000000000000001,
                            HarmScore = 5.0,
                            Name = "Апельсин",
                            Prot = 0.90000000000000002
                        },
                        new
                        {
                            Guid = new Guid("84696186-6697-49de-8844-42ad8347fd15"),
                            Caloriers = 69.0,
                            Carb = 17.600000000000001,
                            Fat = 0.20000000000000001,
                            HarmScore = 8.0,
                            Name = "Виноград",
                            Prot = 0.59999999999999998
                        },
                        new
                        {
                            Guid = new Guid("ad0df4d9-eec2-4fe3-9656-44427eb27d6a"),
                            Caloriers = 57.0,
                            Carb = 12.699999999999999,
                            Fat = 0.10000000000000001,
                            HarmScore = 7.0,
                            Name = "Груша",
                            Prot = 0.40000000000000002
                        },
                        new
                        {
                            Guid = new Guid("32a10e87-49fe-4b28-b7f2-a14c0c237946"),
                            Caloriers = 61.0,
                            Carb = 14.6,
                            Fat = 0.5,
                            HarmScore = 6.0,
                            Name = "Киви",
                            Prot = 1.1000000000000001
                        });
                });

            modelBuilder.Entity("FoodLog.DAL.Entities.ProductCategory", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Percent")
                        .HasColumnType("float");

                    b.Property<Guid>("ProductGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Guid");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("FoodLog.DAL.Entities.Purchase", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<Guid>("ProductGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Guid");

                    b.HasIndex("ProductGuid");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("FoodLog.DAL.Entities.StorageProduct", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("CurrentCost")
                        .HasColumnType("float");

                    b.Property<double>("CurrentWeight")
                        .HasColumnType("float");

                    b.Property<Guid>("ProductGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SourceGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Guid");

                    b.HasIndex("ProductGuid");

                    b.ToTable("StorageProducts");
                });

            modelBuilder.Entity("FoodLog.DAL.Entities.Trash", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProductGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("TrashCost")
                        .HasColumnType("float");

                    b.Property<double>("TrashWeight")
                        .HasColumnType("float");

                    b.Property<Guid>("WriteOffReasonGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Guid");

                    b.HasIndex("ProductGuid");

                    b.HasIndex("WriteOffReasonGuid");

                    b.ToTable("Trashes");
                });

            modelBuilder.Entity("FoodLog.DAL.Entities.WriteOffReason", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ReasonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid");

                    b.ToTable("WriteOffReason");
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.HasOne("FoodLog.DAL.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodLog.DAL.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodLog.DAL.Entities.Consumption", b =>
                {
                    b.HasOne("FoodLog.DAL.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FoodLog.DAL.Entities.Purchase", b =>
                {
                    b.HasOne("FoodLog.DAL.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FoodLog.DAL.Entities.StorageProduct", b =>
                {
                    b.HasOne("FoodLog.DAL.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FoodLog.DAL.Entities.Trash", b =>
                {
                    b.HasOne("FoodLog.DAL.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodLog.DAL.Entities.WriteOffReason", "WriteOffReason")
                        .WithMany()
                        .HasForeignKey("WriteOffReasonGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("WriteOffReason");
                });
#pragma warning restore 612, 618
        }
    }
}
