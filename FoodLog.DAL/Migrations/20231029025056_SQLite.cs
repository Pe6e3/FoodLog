using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodLog.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SQLite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "DishProducts",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProductGuid = table.Column<Guid>(type: "TEXT", nullable: false),
                    DishGuid = table.Column<Guid>(type: "TEXT", nullable: false),
                    Netto = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishProducts", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Calories = table.Column<double>(type: "REAL", nullable: false),
                    Prot = table.Column<double>(type: "REAL", nullable: false),
                    Carb = table.Column<double>(type: "REAL", nullable: false),
                    Fat = table.Column<double>(type: "REAL", nullable: false),
                    HarmScore = table.Column<double>(type: "REAL", nullable: false),
                    TrashPercentage = table.Column<double>(type: "REAL", nullable: false),
                    DishGuid = table.Column<Guid>(type: "TEXT", nullable: true),
                    DishProductGuid = table.Column<Guid>(type: "TEXT", nullable: true)
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
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    ReasonName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WriteOffReasons", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoriesGuid = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProductsGuid = table.Column<Guid>(type: "TEXT", nullable: false)
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
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProductGuid = table.Column<Guid>(type: "TEXT", nullable: false),
                    CategoryGuid = table.Column<Guid>(type: "TEXT", nullable: false),
                    Percent = table.Column<double>(type: "REAL", nullable: false)
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
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    Weight = table.Column<double>(type: "REAL", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Cost = table.Column<double>(type: "REAL", nullable: false),
                    ProductGuid = table.Column<Guid>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    Brutto = table.Column<double>(type: "REAL", nullable: false),
                    Netto = table.Column<double>(type: "REAL", nullable: false),
                    GuidOfPurchase = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProductGuid = table.Column<Guid>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProductGuid = table.Column<Guid>(type: "TEXT", nullable: false),
                    GuidOfPurchase = table.Column<Guid>(type: "TEXT", nullable: false),
                    CurrentWeight = table.Column<double>(type: "REAL", nullable: false),
                    CurrentCost = table.Column<double>(type: "REAL", nullable: false)
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
                    Guid = table.Column<Guid>(type: "TEXT", nullable: false),
                    WriteOffReasonGuid = table.Column<Guid>(type: "TEXT", nullable: false),
                    GuidOfPurchase = table.Column<Guid>(type: "TEXT", nullable: false),
                    TrashWeight = table.Column<double>(type: "REAL", nullable: false),
                    TrashCost = table.Column<double>(type: "REAL", nullable: false),
                    ProductGuid = table.Column<Guid>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                    { new Guid("0e91335b-d0a0-4c49-8a71-11d2efa56346"), "Рыба / Морепродукты" },
                    { new Guid("0f491438-ff22-4d16-844a-f3e72fb2aabb"), "Вода" },
                    { new Guid("102399d4-726f-4518-a2cc-9c669222deb9"), "Кондитерка" },
                    { new Guid("1e5788e1-ddbd-4cd7-be9b-e78b3b3ee4f1"), "Термичка на ПЖП" },
                    { new Guid("2ba3c00f-7f00-48f0-b2ab-4cbf14857348"), "Фрукты" },
                    { new Guid("309a3225-dd48-4df2-a2d2-8b4fca22f456"), "Кофе" },
                    { new Guid("688ffea4-7401-495c-987c-5f8bc1df29ac"), "Сухофрукты" },
                    { new Guid("7530ee04-b294-4fd7-b578-7763ff6aa7a4"), "Молочка" },
                    { new Guid("8c854d14-ae1c-416d-9df3-54510c0487b5"), "Орехи / Злаки / Семена" },
                    { new Guid("9cdd9301-c8df-4157-881b-2c284b143999"), "Зелень / Овощи" },
                    { new Guid("b2a3784e-263d-480e-afd6-342cc06834d5"), "Соки / Чай" },
                    { new Guid("de6179cf-7736-43f8-a034-7e854634a606"), "Яйцо" },
                    { new Guid("e4528903-8841-4155-a8c9-a7b534f03f33"), "Термичка растительная" },
                    { new Guid("f3971a41-523b-4cb0-895a-4830143802e9"), "Мясо" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Guid", "Calories", "Carb", "DishGuid", "DishProductGuid", "Fat", "HarmScore", "Name", "Prot", "TrashPercentage" },
                values: new object[,]
                {
                    { new Guid("3db5763d-e6a5-4f44-977c-39d64ec61840"), 52.0, 11.4, null, null, 0.40000000000000002, 10.0, "Яблоко", 0.29999999999999999, 10.0 },
                    { new Guid("546347c6-5080-4149-b87b-259d0b6dd988"), 59.0, 4.7000000000000002, null, null, 3.0, 15.0, "Йогурт", 3.5, 0.0 },
                    { new Guid("697970ff-4fee-459f-bb53-6dec5a413db5"), 576.0, 6.0, null, null, 49.0, 20.0, "Миндаль", 21.0, 0.0 },
                    { new Guid("b504ca0e-626d-4d02-aed5-b42ee1c94fd3"), 208.0, 0.0, null, null, 14.300000000000001, 25.0, "Лосось", 20.0, 0.0 },
                    { new Guid("b508dca2-45c1-4946-b325-73256b6247f2"), 96.0, 21.0, null, null, 0.20000000000000001, 10.0, "Банан", 1.0, 36.0 },
                    { new Guid("c0bf77c9-7d1b-4886-98dc-299136a5c9a7"), 18.0, 3.8999999999999999, null, null, 0.20000000000000001, 5.0, "Томат", 0.90000000000000002, 5.0 },
                    { new Guid("c455cbae-04a7-410e-ae12-d837822f91fe"), 61.0, 14.6, null, null, 0.5, 6.0, "Киви", 1.1000000000000001, 12.0 },
                    { new Guid("cc2f7bff-9df5-4061-b138-0a25c61d820b"), 69.0, 17.600000000000001, null, null, 0.20000000000000001, 8.0, "Виноград", 0.59999999999999998, 10.0 },
                    { new Guid("efa1e2c5-6ce1-4b6a-9be7-113e55f42e24"), 43.0, 8.1999999999999993, null, null, 0.20000000000000001, 5.0, "Апельсин", 0.90000000000000002, 40.0 },
                    { new Guid("f795a259-ef14-43e7-a5f4-4e6b8342173a"), 57.0, 12.699999999999999, null, null, 0.10000000000000001, 7.0, "Груша", 0.40000000000000002, 3.0 }
                });

            migrationBuilder.InsertData(
                table: "WriteOffReasons",
                columns: new[] { "Guid", "ReasonName" },
                values: new object[,]
                {
                    { new Guid("114e9fa9-9337-4bad-b0c3-782851ac4147"), "Испортился" },
                    { new Guid("12b371d8-ab00-4a7b-8802-d8a0f371ce84"), "Несъедобная часть" },
                    { new Guid("18857c48-f418-4446-bf20-00ca92e12852"), "Угостил" },
                    { new Guid("c6d540f1-15f5-4448-b544-f444528a0a6f"), "Потеря/усушка" }
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
                name: "DishProducts");

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
