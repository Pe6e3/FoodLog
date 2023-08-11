using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodLog.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Dish : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calories = table.Column<double>(type: "float", nullable: false),
                    Prot = table.Column<double>(type: "float", nullable: false),
                    Carb = table.Column<double>(type: "float", nullable: false),
                    Fat = table.Column<double>(type: "float", nullable: false),
                    HarmScore = table.Column<double>(type: "float", nullable: false),
                    TrashPercentage = table.Column<double>(type: "float", nullable: false),
                    DishGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DishProductGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Products_Products_DishProductGuid",
                        column: x => x.DishProductGuid,
                        principalTable: "Products",
                        principalColumn: "Guid");
                });

            migrationBuilder.CreateTable(
                name: "WriteOffReasons",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReasonName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WriteOffReasons", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoriesGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesGuid, x.ProductsGuid });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_CategoriesGuid",
                        column: x => x.CategoriesGuid,
                        principalTable: "Categories",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_ProductsGuid",
                        column: x => x.ProductsGuid,
                        principalTable: "Products",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Percent = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryGuid",
                        column: x => x.CategoryGuid,
                        principalTable: "Categories",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductGuid",
                        column: x => x.ProductGuid,
                        principalTable: "Products",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    ProductGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Purchases_Products_ProductGuid",
                        column: x => x.ProductGuid,
                        principalTable: "Products",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consumptions",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Brutto = table.Column<double>(type: "float", nullable: false),
                    Netto = table.Column<double>(type: "float", nullable: false),
                    GuidOfPurchase = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumptions", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Consumptions_Products_ProductGuid",
                        column: x => x.ProductGuid,
                        principalTable: "Products",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consumptions_Purchases_GuidOfPurchase",
                        column: x => x.GuidOfPurchase,
                        principalTable: "Purchases",
                        principalColumn: "Guid");
                });

            migrationBuilder.CreateTable(
                name: "StorageProducts",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuidOfPurchase = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrentWeight = table.Column<double>(type: "float", nullable: false),
                    CurrentCost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageProducts", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_StorageProducts_Products_ProductGuid",
                        column: x => x.ProductGuid,
                        principalTable: "Products",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StorageProducts_Purchases_GuidOfPurchase",
                        column: x => x.GuidOfPurchase,
                        principalTable: "Purchases",
                        principalColumn: "Guid");
                });

            migrationBuilder.CreateTable(
                name: "Trashes",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WriteOffReasonGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuidOfPurchase = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrashWeight = table.Column<double>(type: "float", nullable: false),
                    TrashCost = table.Column<double>(type: "float", nullable: false),
                    ProductGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trashes", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Trashes_Products_ProductGuid",
                        column: x => x.ProductGuid,
                        principalTable: "Products",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trashes_Purchases_GuidOfPurchase",
                        column: x => x.GuidOfPurchase,
                        principalTable: "Purchases",
                        principalColumn: "Guid");
                    table.ForeignKey(
                        name: "FK_Trashes_WriteOffReasons_WriteOffReasonGuid",
                        column: x => x.WriteOffReasonGuid,
                        principalTable: "WriteOffReasons",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Guid", "Name" },
                values: new object[,]
                {
                    { new Guid("07c78969-f5bb-4068-9015-8a72bae20a43"), "Кофе" },
                    { new Guid("0f75939b-52a1-42d2-8733-955ffcfef745"), "Молочка" },
                    { new Guid("14b98281-5bd2-437f-89c7-319f010cc139"), "Термичка растительная" },
                    { new Guid("234fb3d5-7f1e-45f4-837b-7a1f3481cee9"), "Кондитерка" },
                    { new Guid("23baa3ed-071d-4f84-9c72-63862b896547"), "Соки / Чай" },
                    { new Guid("38206c24-d635-4b04-9139-c37bc72e8545"), "Фрукты" },
                    { new Guid("40d96637-b7fd-4cdf-9d73-e9b793784e21"), "Зелень / Овощи" },
                    { new Guid("4f342060-ef44-4685-ad2c-ba5ae019419f"), "Орехи / Злаки / Семена" },
                    { new Guid("6d5c5245-0bd6-4388-bebd-2027afabde66"), "Сухофрукты" },
                    { new Guid("72498c82-02ca-4d89-b31b-5f3ec3a99795"), "Рыба / Морепродукты" },
                    { new Guid("83575475-c98b-4d7e-a40f-cebe7527650a"), "Мясо" },
                    { new Guid("b3421f98-ce21-4432-96ef-9764fb2ce9f9"), "Вода" },
                    { new Guid("b4f81e13-1d95-4f8f-864b-8fa739c3529a"), "Яйцо" },
                    { new Guid("baa2ceae-130f-477a-8238-ae543438910e"), "Термичка на ПЖП" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Guid", "Calories", "Carb", "DishGuid", "DishProductGuid", "Fat", "HarmScore", "Name", "Prot", "TrashPercentage" },
                values: new object[,]
                {
                    { new Guid("08404a72-21b0-4bbf-bdea-1ca067b31f83"), 43.0, 8.1999999999999993, null, null, 0.20000000000000001, 5.0, "Апельсин", 0.90000000000000002, 40.0 },
                    { new Guid("67012f03-f4bb-4037-b54e-6cfbb27080cc"), 208.0, 0.0, null, null, 14.300000000000001, 25.0, "Лосось", 20.0, 0.0 },
                    { new Guid("6dfc429a-5163-4dcb-8e0d-d0903fcf6579"), 18.0, 3.8999999999999999, null, null, 0.20000000000000001, 5.0, "Томат", 0.90000000000000002, 5.0 },
                    { new Guid("862e7aec-de07-447c-a280-e4e1ddfd1d4e"), 52.0, 11.4, null, null, 0.40000000000000002, 10.0, "Яблоко", 0.29999999999999999, 10.0 },
                    { new Guid("932d3943-7c05-4a8a-9f85-79b3d3edd768"), 61.0, 14.6, null, null, 0.5, 6.0, "Киви", 1.1000000000000001, 12.0 },
                    { new Guid("a01eef5e-0010-4b02-84a7-7659fb4d1819"), 59.0, 4.7000000000000002, null, null, 3.0, 15.0, "Йогурт", 3.5, 0.0 },
                    { new Guid("a8d35511-96d3-4483-8e38-c3c2779e7149"), 96.0, 21.0, null, null, 0.20000000000000001, 10.0, "Банан", 1.0, 36.0 },
                    { new Guid("e12e3243-4320-4bad-b07e-24f93d31f2e8"), 57.0, 12.699999999999999, null, null, 0.10000000000000001, 7.0, "Груша", 0.40000000000000002, 3.0 },
                    { new Guid("ee06e4e0-1b3c-475c-b8f1-eb29005cd3d2"), 576.0, 6.0, null, null, 49.0, 20.0, "Миндаль", 21.0, 0.0 },
                    { new Guid("f3e2babe-ef45-481a-86cd-7f5a9fde4ce2"), 69.0, 17.600000000000001, null, null, 0.20000000000000001, 8.0, "Виноград", 0.59999999999999998, 10.0 }
                });

            migrationBuilder.InsertData(
                table: "WriteOffReasons",
                columns: new[] { "Guid", "ReasonName" },
                values: new object[,]
                {
                    { new Guid("225b09a1-031e-49de-9c86-dd47a1e2af7b"), "Угостил" },
                    { new Guid("76a12b60-6556-4fd5-8570-a98c1e91f80a"), "Потеря/усушка" },
                    { new Guid("a34f0039-884f-4d18-8c8d-4972553d199f"), "Испортился" },
                    { new Guid("c9a62be9-f680-4567-ab2f-3b5a9dcd3abc"), "Несъедобная часть" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsGuid",
                table: "CategoryProduct",
                column: "ProductsGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Consumptions_GuidOfPurchase",
                table: "Consumptions",
                column: "GuidOfPurchase");

            migrationBuilder.CreateIndex(
                name: "IX_Consumptions_ProductGuid",
                table: "Consumptions",
                column: "ProductGuid");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryGuid",
                table: "ProductCategories",
                column: "CategoryGuid");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_ProductGuid",
                table: "ProductCategories",
                column: "ProductGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Products_DishProductGuid",
                table: "Products",
                column: "DishProductGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_ProductGuid",
                table: "Purchases",
                column: "ProductGuid");

            migrationBuilder.CreateIndex(
                name: "IX_StorageProducts_GuidOfPurchase",
                table: "StorageProducts",
                column: "GuidOfPurchase",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StorageProducts_ProductGuid",
                table: "StorageProducts",
                column: "ProductGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Trashes_GuidOfPurchase",
                table: "Trashes",
                column: "GuidOfPurchase");

            migrationBuilder.CreateIndex(
                name: "IX_Trashes_ProductGuid",
                table: "Trashes",
                column: "ProductGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Trashes_WriteOffReasonGuid",
                table: "Trashes",
                column: "WriteOffReasonGuid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "Consumptions");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "StorageProducts");

            migrationBuilder.DropTable(
                name: "Trashes");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Purchases");

            migrationBuilder.DropTable(
                name: "WriteOffReasons");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
