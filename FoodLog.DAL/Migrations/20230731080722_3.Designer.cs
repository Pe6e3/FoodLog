﻿// <auto-generated />
using System;
using FoodLog.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodLog.DAL.Migrations
{
    [DbContext(typeof(FoodLogDbContext))]
    [Migration("20230731080722_3")]
    partial class _3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Guid = new Guid("a85b44c7-428b-497b-9a96-c5059e2eaaac"),
                            Name = "Фрукты"
                        },
                        new
                        {
                            Guid = new Guid("a3265c76-adc4-41a9-a7fa-61f5b1b4298c"),
                            Name = "Сухофрукты"
                        },
                        new
                        {
                            Guid = new Guid("757d103a-b63b-4a26-bce1-1670c760533b"),
                            Name = "Зелень / Овощи"
                        },
                        new
                        {
                            Guid = new Guid("0397e67e-3c45-4988-bb85-525a41b5550a"),
                            Name = "Соки / Чай"
                        },
                        new
                        {
                            Guid = new Guid("2b83bcc0-9288-4bff-b55b-e06ec407d748"),
                            Name = "Вода"
                        },
                        new
                        {
                            Guid = new Guid("5a0882ea-1cef-4108-84d5-74d62a13b1a1"),
                            Name = "Орехи / Злаки / Семена"
                        },
                        new
                        {
                            Guid = new Guid("3f3c5087-e685-46d4-a139-c12f39f49371"),
                            Name = "Термичка растительная"
                        },
                        new
                        {
                            Guid = new Guid("2328134f-aa0c-487d-b502-500ec7b7e025"),
                            Name = "Молочка"
                        },
                        new
                        {
                            Guid = new Guid("b4d90c1c-8fb7-492d-b3a3-0be8348b14f8"),
                            Name = "Яйцо"
                        },
                        new
                        {
                            Guid = new Guid("4c92de82-09af-477e-a808-a2ad93a4d0b4"),
                            Name = "Рыба / Морепродукты"
                        },
                        new
                        {
                            Guid = new Guid("238160c8-f82c-4286-a48b-67512b7a74ef"),
                            Name = "Мясо"
                        },
                        new
                        {
                            Guid = new Guid("5578237b-f421-4ac5-8d25-ab3522b4126f"),
                            Name = "Термичка на ПЖП"
                        },
                        new
                        {
                            Guid = new Guid("62d92b20-23ac-4f28-a0be-bab07697f307"),
                            Name = "Кофе"
                        },
                        new
                        {
                            Guid = new Guid("b6f9759c-bad8-4c8e-a8f2-41e0f6efccca"),
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

                    b.Property<double>("TrashPercentage")
                        .HasColumnType("float");

                    b.HasKey("Guid");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Guid = new Guid("ec8f5e18-0d69-4372-aaf1-272a932cd798"),
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
                            Guid = new Guid("1c3af32a-7fbd-4c43-b12b-3485d833c06a"),
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
                            Guid = new Guid("55b7ea05-878f-4554-b6b6-ea507a6e2832"),
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
                            Guid = new Guid("35aeafb1-cacd-4ea0-a103-f46f3ee20c38"),
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
                            Guid = new Guid("894a9ab0-060c-4a1c-a199-31d25d77fa6f"),
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
                            Guid = new Guid("50c105ec-c66a-4e59-8e6b-55c2b5b1734e"),
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
                            Guid = new Guid("e7507c04-5fbf-4792-bbee-d2ee535ea143"),
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
                            Guid = new Guid("0b5add46-6d22-4a57-a788-4b55cdba8613"),
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
                            Guid = new Guid("bfca28fb-42d1-4c35-9c96-f47f80ff10be"),
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
                            Guid = new Guid("0a6034e2-5b5f-4ae1-9eba-5f617c85cbcf"),
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

                    b.Property<Guid>("ProductGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SourceGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("WeightConsume")
                        .HasColumnType("float");

                    b.Property<double>("WeightRemainsAfter")
                        .HasColumnType("float");

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

                    b.ToTable("WriteOffReasons");

                    b.HasData(
                        new
                        {
                            Guid = new Guid("564666a4-9990-46f0-bd75-636448c36760"),
                            ReasonName = "Несъедобная часть"
                        },
                        new
                        {
                            Guid = new Guid("cc7325f8-47de-4603-bcba-22de71faccc2"),
                            ReasonName = "Потеря/усушка"
                        },
                        new
                        {
                            Guid = new Guid("e40ab665-6390-4642-b989-fee2a5593808"),
                            ReasonName = "Угостил"
                        },
                        new
                        {
                            Guid = new Guid("08f807ee-d375-4ec9-9cd7-b4ddabebf02f"),
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
                        .WithMany("Trashes")
                        .HasForeignKey("WriteOffReasonGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

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
