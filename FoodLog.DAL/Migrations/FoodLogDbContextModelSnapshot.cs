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
                            Guid = new Guid("26fd5306-bf0b-43d4-ba44-4cdd9b2656f4"),
                            Name = "Фрукты"
                        },
                        new
                        {
                            Guid = new Guid("3acae9b6-8506-4a9c-bd32-34db36702df4"),
                            Name = "Сухофрукты"
                        },
                        new
                        {
                            Guid = new Guid("965ed878-64e9-4ce2-a193-e2fce9dd57be"),
                            Name = "Зелень / Овощи"
                        },
                        new
                        {
                            Guid = new Guid("b8d52205-7775-4478-9aac-95249b4078cb"),
                            Name = "Соки / Чай"
                        },
                        new
                        {
                            Guid = new Guid("a9e27af0-b138-4ad3-a690-1b73e3c05e8b"),
                            Name = "Вода"
                        },
                        new
                        {
                            Guid = new Guid("44278d56-c9f4-497f-a70c-45dd40fea258"),
                            Name = "Орехи / Злаки / Семена"
                        },
                        new
                        {
                            Guid = new Guid("9d42513a-2dd6-4cc5-8bc6-8c8b92d58e4a"),
                            Name = "Термичка растительная"
                        },
                        new
                        {
                            Guid = new Guid("7c46c288-9dab-4ab8-a844-6ae9f994f679"),
                            Name = "Молочка"
                        },
                        new
                        {
                            Guid = new Guid("09bfc9a6-cdd5-466f-89e0-f1dcf5b78d14"),
                            Name = "Яйцо"
                        },
                        new
                        {
                            Guid = new Guid("4a027cbc-3002-4314-b163-8d0b8fed8b3c"),
                            Name = "Рыба / Морепродукты"
                        },
                        new
                        {
                            Guid = new Guid("cefd207a-2189-4511-b561-860c4432a7ac"),
                            Name = "Мясо"
                        },
                        new
                        {
                            Guid = new Guid("7a53d1d2-c51f-4f96-a1bd-0d152a8a23a8"),
                            Name = "Термичка на ПЖП"
                        },
                        new
                        {
                            Guid = new Guid("9bc89530-48a3-4a29-ac22-899ac95deee5"),
                            Name = "Кофе"
                        },
                        new
                        {
                            Guid = new Guid("27220565-ed98-4539-a058-ab3052a87a10"),
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
                            Guid = new Guid("49d83145-4fca-4816-b785-446734a6372d"),
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
                            Guid = new Guid("34511e28-683e-4740-8b87-0396c74f246b"),
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
                            Guid = new Guid("db33e6e2-fc02-4247-8fd2-574960fd6165"),
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
                            Guid = new Guid("0628b102-16cc-4faa-b688-21cd5d8c2332"),
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
                            Guid = new Guid("58809d41-a01d-4795-81ad-1148caab64aa"),
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
                            Guid = new Guid("4660dc27-419c-4923-afa8-435632dff217"),
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
                            Guid = new Guid("d3dc68aa-9d55-4c88-a291-57623a8b4638"),
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
                            Guid = new Guid("37b75af3-8cfa-4933-aa33-a5b279128c20"),
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
                            Guid = new Guid("c0d37cca-514c-419a-aefa-8004ea6f7490"),
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
                            Guid = new Guid("b66dcaf8-0634-40f9-99ac-d19022cad85e"),
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
                            Guid = new Guid("8ad473da-1b07-4aba-8c29-a7a572096c2d"),
                            ReasonName = "Несъедобная часть"
                        },
                        new
                        {
                            Guid = new Guid("c7f208bf-5b51-4d95-8c0f-39b526d91ff4"),
                            ReasonName = "Потеря/усушка"
                        },
                        new
                        {
                            Guid = new Guid("41abc6f0-d046-4995-8b16-65905e4de9dc"),
                            ReasonName = "Угостил"
                        },
                        new
                        {
                            Guid = new Guid("2944c545-ce79-4fc4-a92b-300747d0bf94"),
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
