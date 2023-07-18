﻿using FoodLog.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace FoodLog.DAL.Data;

public class FoodLogDbContext : DbContext
{
    public FoodLogDbContext(DbContextOptions<FoodLogDbContext> options) : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Consumption> Consumptions { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<Purchase> Purchases { get; set; }
    public DbSet<StorageProduct> StorageProducts { get; set; }
    public DbSet<Trash> Trashes { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Category>()
            .HasMany(e => e.Products)
            .WithMany(e => e.Categories);



        modelBuilder.Entity<Category>()
            .HasData(
                new Category { Guid = Guid.NewGuid(), Name = "Фрукты" },
                new Category { Guid = Guid.NewGuid(), Name = "Сухофрукты" },
                new Category { Guid = Guid.NewGuid(), Name = "Зелень / Овощи" },
                new Category { Guid = Guid.NewGuid(), Name = "Соки / Чай" },
                new Category { Guid = Guid.NewGuid(), Name = "Вода" },
                new Category { Guid = Guid.NewGuid(), Name = "Орехи / Злаки / Семена" },
                new Category { Guid = Guid.NewGuid(), Name = "Термичка растительная" },
                new Category { Guid = Guid.NewGuid(), Name = "Молочка" },
                new Category { Guid = Guid.NewGuid(), Name = "Яйцо" },
                new Category { Guid = Guid.NewGuid(), Name = "Рыба / Морепродукты" },
                new Category { Guid = Guid.NewGuid(), Name = "Мясо" },
                new Category { Guid = Guid.NewGuid(), Name = "Термичка на ПЖП" },
                new Category { Guid = Guid.NewGuid(), Name = "Кофе" },
                new Category { Guid = Guid.NewGuid(), Name = "Кондитерка" }
            );

        modelBuilder.Entity<Product>()
    .HasData(
        new Product
        {
            Guid = Guid.NewGuid(),

            Name = "Яблоко",
            Caloriers = 52,
            Prot = 0.3,
            Carb = 11.4,
            Fat = 0.4,
            HarmScore = 10, // Примерный уровень вреда (на усмотрение)
        },
        new Product
        {
            Guid = Guid.NewGuid(),
            Name = "Миндаль",
            Caloriers = 576,
            Prot = 21,
            Carb = 6,
            Fat = 49,
            HarmScore = 20, // Примерный уровень вреда (на усмотрение)
        },
        new Product
        {
            Guid = Guid.NewGuid(),
            Name = "Томат",
            Caloriers = 18,
            Prot = 0.9,
            Carb = 3.9,
            Fat = 0.2,
            HarmScore = 5, // Примерный уровень вреда (на усмотрение)
        },
        new Product
        {
            Guid = Guid.NewGuid(),
            Name = "Йогурт",
            Caloriers = 59,
            Prot = 3.5,
            Carb = 4.7,
            Fat = 3.0,
            HarmScore = 15, // Примерный уровень вреда (на усмотрение)
        },
        new Product
        {
            Guid = Guid.NewGuid(),
            Name = "Лосось",
            Caloriers = 208,
            Prot = 20,
            Carb = 0,
            Fat = 14.3,
            HarmScore = 25, // Примерный уровень вреда (на усмотрение)
        },
       new Product
       {
           Guid = Guid.NewGuid(),
           Name = "Банан",
           Caloriers = 96,
           Prot = 1.0,
           Carb = 21.0,
           Fat = 0.2,
           HarmScore = 10, // Примерный уровень вреда (на усмотрение)
       },
        new Product
        {
            Guid = Guid.NewGuid(),
            Name = "Апельсин",
            Caloriers = 43,
            Prot = 0.9,
            Carb = 8.2,
            Fat = 0.2,
            HarmScore = 5, // Примерный уровень вреда (на усмотрение)
        },
        new Product
        {
            Guid = Guid.NewGuid(),
            Name = "Виноград",
            Caloriers = 69,
            Prot = 0.6,
            Carb = 17.6,
            Fat = 0.2,
            HarmScore = 8, // Примерный уровень вреда (на усмотрение)
        },
        new Product
        {
            Guid = Guid.NewGuid(),
            Name = "Груша",
            Caloriers = 57,
            Prot = 0.4,
            Carb = 12.7,
            Fat = 0.1,
            HarmScore = 7, // Примерный уровень вреда (на усмотрение)
        },
        new Product
        {
            Guid = Guid.NewGuid(),
            Name = "Киви",
            Caloriers = 61,
            Prot = 1.1,
            Carb = 14.6,
            Fat = 0.5,
            HarmScore = 6, // Примерный уровень вреда (на усмотрение)
        }
    );

    }
}
