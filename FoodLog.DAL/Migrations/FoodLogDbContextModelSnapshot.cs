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
                            Guid = new Guid("f9e3cbc7-0b2b-42f2-a488-0641afe8f023"),
                            Name = "Фрукты"
                        },
                        new
                        {
                            Guid = new Guid("59079d67-5462-4733-bea3-1d1061eb5afc"),
                            Name = "Сухофрукты"
                        },
                        new
                        {
                            Guid = new Guid("a100c34f-11de-42bb-a594-fae57ffaab3a"),
                            Name = "Зелень / Овощи"
                        },
                        new
                        {
                            Guid = new Guid("071f1252-32f4-4442-becb-c31cfd301177"),
                            Name = "Соки / Чай"
                        },
                        new
                        {
                            Guid = new Guid("b48a007e-c8bf-4735-8a5a-c69fced850bb"),
                            Name = "Вода"
                        },
                        new
                        {
                            Guid = new Guid("f83220f1-84a6-4dbf-bdc6-c61686711a4f"),
                            Name = "Орехи / Злаки / Семена"
                        },
                        new
                        {
                            Guid = new Guid("c4d10c68-7a36-40aa-8133-646deac1d6fe"),
                            Name = "Термичка растительная"
                        },
                        new
                        {
                            Guid = new Guid("e5382202-29ae-4d34-81a1-ef96719770e6"),
                            Name = "Молочка"
                        },
                        new
                        {
                            Guid = new Guid("46f649ae-5a6a-467c-8406-867c4789e848"),
                            Name = "Яйцо"
                        },
                        new
                        {
                            Guid = new Guid("54f76e2c-dbe7-434c-bbc1-ebd8d890ee75"),
                            Name = "Рыба / Морепродукты"
                        },
                        new
                        {
                            Guid = new Guid("699a8a35-eca9-457f-a248-63c64a60a8ea"),
                            Name = "Мясо"
                        },
                        new
                        {
                            Guid = new Guid("732d2ac2-5270-4a6d-9e31-3f6689e21269"),
                            Name = "Термичка на ПЖП"
                        },
                        new
                        {
                            Guid = new Guid("0e268eae-b230-4888-9b20-404dc3a87850"),
                            Name = "Кофе"
                        },
                        new
                        {
                            Guid = new Guid("03fff7fe-49aa-4a58-9cea-8046d7a27010"),
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

                    b.Property<Guid?>("PurchaseGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("TrashPercentage")
                        .HasColumnType("float");

                    b.Property<double>("TrashWeight")
                        .HasColumnType("float");

                    b.HasKey("Guid");

                    b.HasIndex("ProductGuid");

                    b.HasIndex("PurchaseGuid");

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

                    b.Property<double>("TrashPercentage")
                        .HasColumnType("float");

                    b.HasKey("Guid");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Guid = new Guid("2f19563a-71c6-44b9-9038-9b1fd6eac48c"),
                            Caloriers = 52.0,
                            Carb = 11.4,
                            Fat = 0.40000000000000002,
                            HarmScore = 10.0,
                            Name = "Яблоко",
                            Prot = 0.29999999999999999,
                            TrashPercentage = 10.0
                        },
                        new
                        {
                            Guid = new Guid("227fdac2-9579-433f-8808-330693845bac"),
                            Caloriers = 576.0,
                            Carb = 6.0,
                            Fat = 49.0,
                            HarmScore = 20.0,
                            Name = "Миндаль",
                            Prot = 21.0,
                            TrashPercentage = 0.0
                        },
                        new
                        {
                            Guid = new Guid("6d82f84f-78d2-4c25-b44d-7a20db3a01bb"),
                            Caloriers = 18.0,
                            Carb = 3.8999999999999999,
                            Fat = 0.20000000000000001,
                            HarmScore = 5.0,
                            Name = "Томат",
                            Prot = 0.90000000000000002,
                            TrashPercentage = 5.0
                        },
                        new
                        {
                            Guid = new Guid("21053fa8-2773-487e-a528-056a955ffb1f"),
                            Caloriers = 59.0,
                            Carb = 4.7000000000000002,
                            Fat = 3.0,
                            HarmScore = 15.0,
                            Name = "Йогурт",
                            Prot = 3.5,
                            TrashPercentage = 0.0
                        },
                        new
                        {
                            Guid = new Guid("c7b04535-da00-4dac-9ccf-0465ec9c5471"),
                            Caloriers = 208.0,
                            Carb = 0.0,
                            Fat = 14.300000000000001,
                            HarmScore = 25.0,
                            Name = "Лосось",
                            Prot = 20.0,
                            TrashPercentage = 0.0
                        },
                        new
                        {
                            Guid = new Guid("504f980a-f542-4497-a367-31c058bcd3da"),
                            Caloriers = 96.0,
                            Carb = 21.0,
                            Fat = 0.20000000000000001,
                            HarmScore = 10.0,
                            Name = "Банан",
                            Prot = 1.0,
                            TrashPercentage = 36.0
                        },
                        new
                        {
                            Guid = new Guid("919937f4-40aa-434b-b2b9-115012de1c3b"),
                            Caloriers = 43.0,
                            Carb = 8.1999999999999993,
                            Fat = 0.20000000000000001,
                            HarmScore = 5.0,
                            Name = "Апельсин",
                            Prot = 0.90000000000000002,
                            TrashPercentage = 40.0
                        },
                        new
                        {
                            Guid = new Guid("6f18db73-1a0b-48c3-90a5-f66e885d9e75"),
                            Caloriers = 69.0,
                            Carb = 17.600000000000001,
                            Fat = 0.20000000000000001,
                            HarmScore = 8.0,
                            Name = "Виноград",
                            Prot = 0.59999999999999998,
                            TrashPercentage = 10.0
                        },
                        new
                        {
                            Guid = new Guid("f25419b3-25e5-4664-b87c-da604ea27537"),
                            Caloriers = 57.0,
                            Carb = 12.699999999999999,
                            Fat = 0.10000000000000001,
                            HarmScore = 7.0,
                            Name = "Груша",
                            Prot = 0.40000000000000002,
                            TrashPercentage = 3.0
                        },
                        new
                        {
                            Guid = new Guid("3ccebda1-95e2-4859-908f-8c123f905494"),
                            Caloriers = 61.0,
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
                            Guid = new Guid("d6145eb6-97ec-44c1-b67d-47a0a754684e"),
                            ReasonName = "Несъедобная часть"
                        },
                        new
                        {
                            Guid = new Guid("4f698828-df69-4157-a0ed-250ccc028780"),
                            ReasonName = "Потеря/усушка"
                        },
                        new
                        {
                            Guid = new Guid("2ef6cb7c-2e7c-425f-970a-519fa6a1e5f8"),
                            ReasonName = "Угостил"
                        },
                        new
                        {
                            Guid = new Guid("1fe4feac-fd5f-420b-b7ad-a840eb457878"),
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
                    b.HasOne("FoodLog.DAL.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodLog.DAL.Entities.Purchase", "Purchase")
                        .WithMany()
                        .HasForeignKey("PurchaseGuid");

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
