using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodLog.DAL.Migrations
{
    /// <inheritdoc />
    public partial class GuidSourceAdd : Migration
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
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Caloriers = table.Column<double>(type: "float", nullable: false),
                    Prot = table.Column<double>(type: "float", nullable: false),
                    Carb = table.Column<double>(type: "float", nullable: false),
                    Fat = table.Column<double>(type: "float", nullable: false),
                    HarmScore = table.Column<double>(type: "float", nullable: false),
                    TrashPercentage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Guid);
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
                    TrashPercentage = table.Column<double>(type: "float", nullable: false),
                    TrashWeight = table.Column<double>(type: "float", nullable: false),
                    GuidOfPurchase = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PurchaseGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        name: "FK_Consumptions_Purchases_PurchaseGuid",
                        column: x => x.PurchaseGuid,
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
                    CurrentCost = table.Column<double>(type: "float", nullable: false),
                    WeightConsume = table.Column<double>(type: "float", nullable: false),
                    WeightRemainsAfter = table.Column<double>(type: "float", nullable: false)
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
                    { new Guid("03fff7fe-49aa-4a58-9cea-8046d7a27010"), "Кондитерка" },
                    { new Guid("071f1252-32f4-4442-becb-c31cfd301177"), "Соки / Чай" },
                    { new Guid("0e268eae-b230-4888-9b20-404dc3a87850"), "Кофе" },
                    { new Guid("46f649ae-5a6a-467c-8406-867c4789e848"), "Яйцо" },
                    { new Guid("54f76e2c-dbe7-434c-bbc1-ebd8d890ee75"), "Рыба / Морепродукты" },
                    { new Guid("59079d67-5462-4733-bea3-1d1061eb5afc"), "Сухофрукты" },
                    { new Guid("699a8a35-eca9-457f-a248-63c64a60a8ea"), "Мясо" },
                    { new Guid("732d2ac2-5270-4a6d-9e31-3f6689e21269"), "Термичка на ПЖП" },
                    { new Guid("a100c34f-11de-42bb-a594-fae57ffaab3a"), "Зелень / Овощи" },
                    { new Guid("b48a007e-c8bf-4735-8a5a-c69fced850bb"), "Вода" },
                    { new Guid("c4d10c68-7a36-40aa-8133-646deac1d6fe"), "Термичка растительная" },
                    { new Guid("e5382202-29ae-4d34-81a1-ef96719770e6"), "Молочка" },
                    { new Guid("f83220f1-84a6-4dbf-bdc6-c61686711a4f"), "Орехи / Злаки / Семена" },
                    { new Guid("f9e3cbc7-0b2b-42f2-a488-0641afe8f023"), "Фрукты" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Guid", "Caloriers", "Carb", "Fat", "HarmScore", "Name", "Prot", "TrashPercentage" },
                values: new object[,]
                {
                    { new Guid("21053fa8-2773-487e-a528-056a955ffb1f"), 59.0, 4.7000000000000002, 3.0, 15.0, "Йогурт", 3.5, 0.0 },
                    { new Guid("227fdac2-9579-433f-8808-330693845bac"), 576.0, 6.0, 49.0, 20.0, "Миндаль", 21.0, 0.0 },
                    { new Guid("2f19563a-71c6-44b9-9038-9b1fd6eac48c"), 52.0, 11.4, 0.40000000000000002, 10.0, "Яблоко", 0.29999999999999999, 10.0 },
                    { new Guid("3ccebda1-95e2-4859-908f-8c123f905494"), 61.0, 14.6, 0.5, 6.0, "Киви", 1.1000000000000001, 12.0 },
                    { new Guid("504f980a-f542-4497-a367-31c058bcd3da"), 96.0, 21.0, 0.20000000000000001, 10.0, "Банан", 1.0, 36.0 },
                    { new Guid("6d82f84f-78d2-4c25-b44d-7a20db3a01bb"), 18.0, 3.8999999999999999, 0.20000000000000001, 5.0, "Томат", 0.90000000000000002, 5.0 },
                    { new Guid("6f18db73-1a0b-48c3-90a5-f66e885d9e75"), 69.0, 17.600000000000001, 0.20000000000000001, 8.0, "Виноград", 0.59999999999999998, 10.0 },
                    { new Guid("919937f4-40aa-434b-b2b9-115012de1c3b"), 43.0, 8.1999999999999993, 0.20000000000000001, 5.0, "Апельсин", 0.90000000000000002, 40.0 },
                    { new Guid("c7b04535-da00-4dac-9ccf-0465ec9c5471"), 208.0, 0.0, 14.300000000000001, 25.0, "Лосось", 20.0, 0.0 },
                    { new Guid("f25419b3-25e5-4664-b87c-da604ea27537"), 57.0, 12.699999999999999, 0.10000000000000001, 7.0, "Груша", 0.40000000000000002, 3.0 }
                });

            migrationBuilder.InsertData(
                table: "WriteOffReasons",
                columns: new[] { "Guid", "ReasonName" },
                values: new object[,]
                {
                    { new Guid("1fe4feac-fd5f-420b-b7ad-a840eb457878"), "Испортился" },
                    { new Guid("2ef6cb7c-2e7c-425f-970a-519fa6a1e5f8"), "Угостил" },
                    { new Guid("4f698828-df69-4157-a0ed-250ccc028780"), "Потеря/усушка" },
                    { new Guid("d6145eb6-97ec-44c1-b67d-47a0a754684e"), "Несъедобная часть" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsGuid",
                table: "CategoryProduct",
                column: "ProductsGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Consumptions_ProductGuid",
                table: "Consumptions",
                column: "ProductGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Consumptions_PurchaseGuid",
                table: "Consumptions",
                column: "PurchaseGuid");

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
