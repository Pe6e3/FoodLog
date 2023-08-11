using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodLog.DAL.Migrations
{
    /// <inheritdoc />
    public partial class dishRemove : Migration
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
                name: "ProductsStorage",
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
                    table.PrimaryKey("PK_ProductsStorage", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_ProductsStorage_Products_ProductGuid",
                        column: x => x.ProductGuid,
                        principalTable: "Products",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsStorage_Purchases_GuidOfPurchase",
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
                    { new Guid("0099f266-dad2-4f16-aaf4-b63bfcc13e92"), "Кондитерка" },
                    { new Guid("067311d4-d36d-494c-99a4-f54a2bded07f"), "Термичка на ПЖП" },
                    { new Guid("0a4d823f-30d8-42b5-bd11-80ab2a9c9c46"), "Сухофрукты" },
                    { new Guid("0d064621-9e33-49e0-9e09-2ef927b440d5"), "Соки / Чай" },
                    { new Guid("4ddc0ce3-2bdc-4d39-866a-4a192d2ec68d"), "Вода" },
                    { new Guid("53567ccd-3f73-4975-9408-b80989a5c385"), "Яйцо" },
                    { new Guid("54903d38-39b0-4829-9c8f-cc2a494dd58d"), "Термичка растительная" },
                    { new Guid("62865e82-3da2-4974-b1d6-d4c160ddacb4"), "Фрукты" },
                    { new Guid("64b1d037-a7ea-4c42-9992-e9925e9f07a0"), "Рыба / Морепродукты" },
                    { new Guid("6feba93e-8b5d-4f97-97bd-29d22b903666"), "Молочка" },
                    { new Guid("86ba7961-f8c2-4ba5-aa52-2d8bb86cf416"), "Орехи / Злаки / Семена" },
                    { new Guid("87b29600-86ca-4798-a6fb-3bc44ffdac59"), "Мясо" },
                    { new Guid("b7f6a38c-0262-492c-8296-80485da142f9"), "Зелень / Овощи" },
                    { new Guid("bc6a6a7e-dcd3-4bf7-a2e8-ca7eca136f06"), "Кофе" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Guid", "Calories", "Carb", "DishGuid", "DishProductGuid", "Fat", "HarmScore", "Name", "Prot", "TrashPercentage" },
                values: new object[,]
                {
                    { new Guid("29c8e516-f251-450a-9cbd-c98b0d29d0a5"), 43.0, 8.1999999999999993, null, null, 0.20000000000000001, 5.0, "Апельсин", 0.90000000000000002, 40.0 },
                    { new Guid("53a73521-7c76-4ca1-82bf-6127d78d23e0"), 59.0, 4.7000000000000002, null, null, 3.0, 15.0, "Йогурт", 3.5, 0.0 },
                    { new Guid("5bd81539-0eff-4e13-ad95-f194db444820"), 208.0, 0.0, null, null, 14.300000000000001, 25.0, "Лосось", 20.0, 0.0 },
                    { new Guid("7cad76e2-4713-4791-a8ba-8da88091ed0f"), 576.0, 6.0, null, null, 49.0, 20.0, "Миндаль", 21.0, 0.0 },
                    { new Guid("7fde6071-0ad6-47b1-8a9f-bfa48c2116f8"), 69.0, 17.600000000000001, null, null, 0.20000000000000001, 8.0, "Виноград", 0.59999999999999998, 10.0 },
                    { new Guid("c541d0b3-bd04-4156-a37a-030bd337854b"), 57.0, 12.699999999999999, null, null, 0.10000000000000001, 7.0, "Груша", 0.40000000000000002, 3.0 },
                    { new Guid("d2991858-5424-4c62-804d-a296ac4361eb"), 18.0, 3.8999999999999999, null, null, 0.20000000000000001, 5.0, "Томат", 0.90000000000000002, 5.0 },
                    { new Guid("ea977f6c-f848-4f7f-b2d6-e947fab1668f"), 61.0, 14.6, null, null, 0.5, 6.0, "Киви", 1.1000000000000001, 12.0 },
                    { new Guid("eb5abca4-238e-42d7-921f-a0fc969458ab"), 96.0, 21.0, null, null, 0.20000000000000001, 10.0, "Банан", 1.0, 36.0 },
                    { new Guid("fb95ffbf-b040-424c-a84e-d00ad303e5a9"), 52.0, 11.4, null, null, 0.40000000000000002, 10.0, "Яблоко", 0.29999999999999999, 10.0 }
                });

            migrationBuilder.InsertData(
                table: "WriteOffReasons",
                columns: new[] { "Guid", "ReasonName" },
                values: new object[,]
                {
                    { new Guid("0055bc91-aa84-49d2-9dfe-1e520172543a"), "Угостил" },
                    { new Guid("3984671d-7a64-4bad-b050-cdc70207a03f"), "Потеря/усушка" },
                    { new Guid("a3d1db6e-c9fc-4453-9853-908f50fe8609"), "Испортился" },
                    { new Guid("c4536722-b2d9-46be-b9b5-596731f34cf2"), "Несъедобная часть" }
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
                name: "IX_ProductsStorage_GuidOfPurchase",
                table: "ProductsStorage",
                column: "GuidOfPurchase",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductsStorage_ProductGuid",
                table: "ProductsStorage",
                column: "ProductGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_ProductGuid",
                table: "Purchases",
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
                name: "ProductsStorage");

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
