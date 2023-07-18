using FoodLog.DAL.Entities;
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
                new Category { Name = "Фрукты" },
                new Category { Name = "Сухофрукты" },
                new Category { Name = "Зелень / Овощи" },
                new Category { Name = "Соки / Чай" },
                new Category { Name = "Вода" },
                new Category { Name = "Орехи / Злаки / Семена" },
                new Category { Name = "Термичка растительная" },
                new Category { Name = "Молочка" },
                new Category { Name = "Яйцо" },
                new Category { Name = "Рыба / Морепродукты" },
                new Category { Name = "Мясо" },
                new Category { Name = "Термичка на ПЖП" },
                new Category { Name = "Кофе" },
                new Category { Name = "Кондитерка" }
            );
        modelBuilder.Entity<Product>()
    .HasData(
        new Product
        {
            Name = "Яблоко",
            Caloriers = 52,
            Prot = 0.3,
            Carb = 11.4,
            Fat = 0.4,
            HarmScore = 10, // Примерный уровень вреда (на усмотрение)
            Categories = new List<Category>
            {
                new Category { Name = "Фрукты" }
            }
        },
        new Product
        {
            Name = "Миндаль",
            Caloriers = 576,
            Prot = 21,
            Carb = 6,
            Fat = 49,
            HarmScore = 20, // Примерный уровень вреда (на усмотрение)
            Categories = new List<Category>
            {
                new Category { Name = "Орехи / Злаки / Семена" }
            }
        },
        new Product
        {
            Name = "Томат",
            Caloriers = 18,
            Prot = 0.9,
            Carb = 3.9,
            Fat = 0.2,
            HarmScore = 5, // Примерный уровень вреда (на усмотрение)
            Categories = new List<Category>
            {
                new Category { Name = "Зелень / Овощи" }
            }
        },
        new Product
        {
            Name = "Йогурт",
            Caloriers = 59,
            Prot = 3.5,
            Carb = 4.7,
            Fat = 3.0,
            HarmScore = 15, // Примерный уровень вреда (на усмотрение)
            Categories = new List<Category>
            {
                new Category { Name = "Молочка" }
            }
        },
        new Product
        {
            Name = "Лосось",
            Caloriers = 208,
            Prot = 20,
            Carb = 0,
            Fat = 14.3,
            HarmScore = 25, // Примерный уровень вреда (на усмотрение)
            Categories = new List<Category>
            {
                new Category { Name = "Рыба / Морепродукты" }
            }
        }
    );

    }
}
