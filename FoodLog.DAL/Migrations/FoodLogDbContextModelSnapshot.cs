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
                            Guid = new Guid("d948f478-6727-4b50-8cd1-6a74accc12ad"),
                            Name = "Фрукты"
                        },
                        new
                        {
                            Guid = new Guid("b4e5a9d6-890a-4994-a7ad-544fc30547e7"),
                            Name = "Сухофрукты"
                        },
                        new
                        {
                            Guid = new Guid("17341319-ffca-4597-9820-78427d90901e"),
                            Name = "Зелень / Овощи"
                        },
                        new
                        {
                            Guid = new Guid("f53399f7-b87d-4e76-9dc6-35bcea68a5d0"),
                            Name = "Соки / Чай"
                        },
                        new
                        {
                            Guid = new Guid("6b108568-7492-4808-a335-ec5374673d68"),
                            Name = "Вода"
                        },
                        new
                        {
                            Guid = new Guid("8942e60e-5463-47a3-b2ff-7107e63fd176"),
                            Name = "Орехи / Злаки / Семена"
                        },
                        new
                        {
                            Guid = new Guid("cfac30be-aab0-423e-8b21-577009651e54"),
                            Name = "Термичка растительная"
                        },
                        new
                        {
                            Guid = new Guid("5dac8a43-312d-4ff0-a2b1-f8e89e18c724"),
                            Name = "Молочка"
                        },
                        new
                        {
                            Guid = new Guid("0f909ffa-94b8-4b1c-9aa8-7b11af56ad8c"),
                            Name = "Яйцо"
                        },
                        new
                        {
                            Guid = new Guid("22c9fdb0-405a-4980-827d-bcbd0bcfc24a"),
                            Name = "Рыба / Морепродукты"
                        },
                        new
                        {
                            Guid = new Guid("e12db112-0b4f-49ca-8ca5-5be812f29e41"),
                            Name = "Мясо"
                        },
                        new
                        {
                            Guid = new Guid("b1758d9a-7b62-4554-bf4d-a0745d48a31f"),
                            Name = "Термичка на ПЖП"
                        },
                        new
                        {
                            Guid = new Guid("b078ee2c-9755-4104-b207-ca8b0ffebc5b"),
                            Name = "Кофе"
                        },
                        new
                        {
                            Guid = new Guid("e975bdc5-2259-4c2b-a2ea-fe338245dc95"),
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

                    b.Property<Guid>("GuidOfPurchase")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Netto")
                        .HasColumnType("float");

                    b.Property<Guid>("ProductGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Guid");

                    b.HasIndex("GuidOfPurchase");

                    b.HasIndex("ProductGuid");

                    b.ToTable("Consumptions");
                });

            modelBuilder.Entity("FoodLog.DAL.Entities.Product", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Calories")
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

                    b.Property<double>("TrashPercentage")
                        .HasColumnType("float");

                    b.HasKey("Guid");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Guid = new Guid("58bc0865-e883-4c60-bf47-1f822d2acb8e"),
                            Calories = 52.0,
                            Carb = 11.4,
                            Fat = 0.40000000000000002,
                            HarmScore = 10.0,
                            Name = "Яблоко",
                            Prot = 0.29999999999999999,
                            TrashPercentage = 10.0
                        },
                        new
                        {
                            Guid = new Guid("171cdd2c-02f4-4abe-8a33-1f7a7eded799"),
                            Calories = 576.0,
                            Carb = 6.0,
                            Fat = 49.0,
                            HarmScore = 20.0,
                            Name = "Миндаль",
                            Prot = 21.0,
                            TrashPercentage = 0.0
                        },
                        new
                        {
                            Guid = new Guid("04cbbc23-bf00-4fbb-bc52-000b6cda1c23"),
                            Calories = 18.0,
                            Carb = 3.8999999999999999,
                            Fat = 0.20000000000000001,
                            HarmScore = 5.0,
                            Name = "Томат",
                            Prot = 0.90000000000000002,
                            TrashPercentage = 5.0
                        },
                        new
                        {
                            Guid = new Guid("0d7acc9a-695f-430a-8e7d-d2f2db4a9345"),
                            Calories = 59.0,
                            Carb = 4.7000000000000002,
                            Fat = 3.0,
                            HarmScore = 15.0,
                            Name = "Йогурт",
                            Prot = 3.5,
                            TrashPercentage = 0.0
                        },
                        new
                        {
                            Guid = new Guid("a799e640-5ad3-4dee-896c-8f98384156fa"),
                            Calories = 208.0,
                            Carb = 0.0,
                            Fat = 14.300000000000001,
                            HarmScore = 25.0,
                            Name = "Лосось",
                            Prot = 20.0,
                            TrashPercentage = 0.0
                        },
                        new
                        {
                            Guid = new Guid("5ca7b70f-5841-4889-b5d5-1c25a875f7cc"),
                            Calories = 96.0,
                            Carb = 21.0,
                            Fat = 0.20000000000000001,
                            HarmScore = 10.0,
                            Name = "Банан",
                            Prot = 1.0,
                            TrashPercentage = 36.0
                        },
                        new
                        {
                            Guid = new Guid("1cc91186-3e14-4ada-ba41-5ac9ead75cb5"),
                            Calories = 43.0,
                            Carb = 8.1999999999999993,
                            Fat = 0.20000000000000001,
                            HarmScore = 5.0,
                            Name = "Апельсин",
                            Prot = 0.90000000000000002,
                            TrashPercentage = 40.0
                        },
                        new
                        {
                            Guid = new Guid("1d3d5a7e-4e18-42a4-8741-d34f9196525d"),
                            Calories = 69.0,
                            Carb = 17.600000000000001,
                            Fat = 0.20000000000000001,
                            HarmScore = 8.0,
                            Name = "Виноград",
                            Prot = 0.59999999999999998,
                            TrashPercentage = 10.0
                        },
                        new
                        {
                            Guid = new Guid("6c536930-3e1e-46f8-adb5-dae229832155"),
                            Calories = 57.0,
                            Carb = 12.699999999999999,
                            Fat = 0.10000000000000001,
                            HarmScore = 7.0,
                            Name = "Груша",
                            Prot = 0.40000000000000002,
                            TrashPercentage = 3.0
                        },
                        new
                        {
                            Guid = new Guid("5cd1c23b-7c95-41cd-af32-12d41190ff14"),
                            Calories = 61.0,
                            Carb = 14.6,
                            Fat = 0.5,
                            HarmScore = 6.0,
                            Name = "Киви",
                            Prot = 1.1000000000000001,
                            TrashPercentage = 12.0
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

                    b.Property<Guid>("GuidOfPurchase")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("WeightConsume")
                        .HasColumnType("float");

                    b.Property<double>("WeightRemainsAfter")
                        .HasColumnType("float");

                    b.HasKey("Guid");

                    b.HasIndex("GuidOfPurchase")
                        .IsUnique();

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

                    b.Property<Guid>("GuidOfPurchase")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("TrashCost")
                        .HasColumnType("float");

                    b.Property<double>("TrashWeight")
                        .HasColumnType("float");

                    b.Property<Guid>("WriteOffReasonGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Guid");

                    b.HasIndex("GuidOfPurchase");

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

                    b.ToTable("WriteOffReasons");

                    b.HasData(
                        new
                        {
                            Guid = new Guid("b4f4d12c-358d-493e-a4a9-ec3eb3645a9f"),
                            ReasonName = "Несъедобная часть"
                        },
                        new
                        {
                            Guid = new Guid("cbc06795-b9b5-4cdd-bac2-9b603cd77723"),
                            ReasonName = "Потеря/усушка"
                        },
                        new
                        {
                            Guid = new Guid("a061bedc-81c4-4a29-8ed5-f428a391a57a"),
                            ReasonName = "Угостил"
                        },
                        new
                        {
                            Guid = new Guid("3c1b888e-cde8-45e4-b494-ae2d66b3f840"),
                            ReasonName = "Испортился"
                        });
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
                    b.HasOne("FoodLog.DAL.Entities.Purchase", "Purchase")
                        .WithMany()
                        .HasForeignKey("GuidOfPurchase")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FoodLog.DAL.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Purchase");
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
                    b.HasOne("FoodLog.DAL.Entities.Purchase", "Purchase")
                        .WithOne()
                        .HasForeignKey("FoodLog.DAL.Entities.StorageProduct", "GuidOfPurchase")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FoodLog.DAL.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Purchase");
                });

            modelBuilder.Entity("FoodLog.DAL.Entities.Trash", b =>
                {
                    b.HasOne("FoodLog.DAL.Entities.Purchase", "Purchase")
                        .WithMany()
                        .HasForeignKey("GuidOfPurchase")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FoodLog.DAL.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodLog.DAL.Entities.WriteOffReason", "WriteOffReason")
                        .WithMany("Trashes")
                        .HasForeignKey("WriteOffReasonGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Purchase");

                    b.Navigation("WriteOffReason");
                });

            modelBuilder.Entity("FoodLog.DAL.Entities.WriteOffReason", b =>
                {
                    b.Navigation("Trashes");
                });
#pragma warning restore 612, 618
        }
    }
}
