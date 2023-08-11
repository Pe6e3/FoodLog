using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodLog.DAL.Migrations
{
    /// <inheritdoc />
    public partial class dishProd : Migration
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
                name: "DishProducts",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DishGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Netto = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishProducts", x => x.Guid);
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
                    { new Guid("137c3e26-eab6-44cf-a2a5-259f8203537b"), "Сухофрукты" },
                    { new Guid("548d2491-85a0-4d8e-b0a4-eab5f1efb4bd"), "Фрукты" },
                    { new Guid("641ec661-044f-449a-8d75-9d256bb7bf92"), "Термичка на ПЖП" },
                    { new Guid("7a113b56-8052-47ae-8325-58ac5ca14872"), "Орехи / Злаки / Семена" },
                    { new Guid("8f1c1c4b-4d65-46e4-a46c-f268248cc211"), "Зелень / Овощи" },
                    { new Guid("8f95b097-bd26-4aae-9319-187ab4748d5c"), "Яйцо" },
                    { new Guid("94ad6b7c-d567-41b9-a31d-f5a82a54b372"), "Кондитерка" },
                    { new Guid("bb3c6a1c-940b-4761-9878-10c8d65ae906"), "Соки / Чай" },
                    { new Guid("c8adc57a-6006-4f4f-a0a3-775d192d34de"), "Молочка" },
                    { new Guid("d0577fdd-469f-49d3-9d57-82abbd3f844c"), "Кофе" },
                    { new Guid("d9a40f68-a4cf-4bec-8f19-aed844c00c0c"), "Мясо" },
                    { new Guid("dc9d6b8e-5249-40ef-b682-f26dec0f6e55"), "Термичка растительная" },
                    { new Guid("ecf54852-e7e4-47d0-8394-f029116c52ce"), "Вода" },
                    { new Guid("efacef74-ef15-475d-a1e6-34f344edf6bd"), "Рыба / Морепродукты" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Guid", "Calories", "Carb", "DishGuid", "DishProductGuid", "Fat", "HarmScore", "Name", "Prot", "TrashPercentage" },
                values: new object[,]
                {
                    { new Guid("016bd990-2324-4289-b538-d7712311c4f7"), 576.0, 6.0, null, null, 49.0, 20.0, "Миндаль", 21.0, 0.0 },
                    { new Guid("25e2197e-7d6b-42c0-84f5-6522e368165a"), 52.0, 11.4, null, null, 0.40000000000000002, 10.0, "Яблоко", 0.29999999999999999, 10.0 },
                    { new Guid("25e75927-182d-4a39-9d32-4f97f5c3442f"), 61.0, 14.6, null, null, 0.5, 6.0, "Киви", 1.1000000000000001, 12.0 },
                    { new Guid("29e0540a-b926-4de6-9367-b50e1f4645b1"), 18.0, 3.8999999999999999, null, null, 0.20000000000000001, 5.0, "Томат", 0.90000000000000002, 5.0 },
                    { new Guid("6962cf53-e203-4106-9b07-1294a3bd4467"), 208.0, 0.0, null, null, 14.300000000000001, 25.0, "Лосось", 20.0, 0.0 },
                    { new Guid("7d0b874f-44ba-497d-a39c-de8b4bbbec0f"), 59.0, 4.7000000000000002, null, null, 3.0, 15.0, "Йогурт", 3.5, 0.0 },
                    { new Guid("8f218e7e-fc25-4366-b6f0-fb6a3d1427eb"), 69.0, 17.600000000000001, null, null, 0.20000000000000001, 8.0, "Виноград", 0.59999999999999998, 10.0 },
                    { new Guid("cd7bd281-41f2-4cd7-964a-1c2c75b8f349"), 57.0, 12.699999999999999, null, null, 0.10000000000000001, 7.0, "Груша", 0.40000000000000002, 3.0 },
                    { new Guid("d1e59fe5-ac76-4a8d-9617-bb052c8ddf93"), 96.0, 21.0, null, null, 0.20000000000000001, 10.0, "Банан", 1.0, 36.0 },
                    { new Guid("f6148acb-f0c6-4bb3-b631-2ddf9c35b696"), 43.0, 8.1999999999999993, null, null, 0.20000000000000001, 5.0, "Апельсин", 0.90000000000000002, 40.0 }
                });

            migrationBuilder.InsertData(
                table: "WriteOffReasons",
                columns: new[] { "Guid", "ReasonName" },
                values: new object[,]
                {
                    { new Guid("1bb45254-0899-4a03-bcc0-05e935996c32"), "Несъедобная часть" },
                    { new Guid("3b31cee1-5b99-4a2f-8807-79b5b21540fe"), "Испортился" },
                    { new Guid("44a10577-b20c-40a5-abf9-ed2216befd2e"), "Потеря/усушка" },
                    { new Guid("b8854e5f-b044-4d18-adf9-442861e05fb8"), "Угостил" }
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
