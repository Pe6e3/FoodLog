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
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("03387044-19eb-476a-9cb4-7c86dd27d6af"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("0a0a5d72-0e7a-46e9-a4dd-c3347d4fde0a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("3e634cc4-d9c4-4ac3-9776-894aa1fdde1f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("6010096c-4205-4ddb-96bc-519ae1d5361a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("62df2ecd-15b7-467e-ac27-d11587a6510a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("6364bd27-21ee-4c7c-9ad2-dfb9569a773d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("666107ba-a731-45c2-aa76-9f188ebb7933"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("78341d5c-1575-4d5f-9f36-538da49a1841"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("8ab2a91e-ccca-4b9e-9c74-aaad5add7959"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("be28a394-2056-47e4-a763-d375f2429d3b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("c7a769d4-1604-429f-b787-bbf14aea5463"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("d47185ff-34fa-4978-a35f-4bbb1ec85af8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("e8b97d52-268e-47e0-a34c-d0c4c21baae1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("fca20941-ad37-4490-92d4-b7370f96b610"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("0a5aec3b-70a4-4073-836c-eb9d2c33061a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("1198995d-7ecb-41a7-be77-b001716e44e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("4a427e74-037f-4b00-9563-47ed98f594f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("54eff23a-f5ea-4b5e-9c1e-ee67a246dd81"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("82230e1a-230e-4f8c-b0b3-17f865b9188f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("a0f59496-43d0-4921-bac9-e2555a25829e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("d23f6ff7-9914-4fda-a6b0-a207e99f0061"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("d8c0c59a-a04d-411b-a298-bd9ef516445f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("e0734383-313d-4182-bd4e-266a76f9c4a7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fe468b74-e89a-4431-9724-40130c341c28"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("0ddf366a-24f3-4bbd-a349-e7f8591de5ca"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("338694e7-12fc-46ae-85df-682623106403"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("e0adb972-f0c0-44e8-a3c0-1c8387ea18d2"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("f99b3b76-e67c-433d-b118-c9e01b77a16f"));

            migrationBuilder.AddColumn<Guid>(
                name: "PurchaseGuid",
                table: "Trashes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SourceGuid",
                table: "Trashes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PurchaseGuid",
                table: "StorageProducts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PurchaseGuid",
                table: "Consumptions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SourceGuid",
                table: "Consumptions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Guid", "Name" },
                values: new object[,]
                {
                    { new Guid("01af66b3-fe59-4156-8d89-3635ef794718"), "Сухофрукты" },
                    { new Guid("0b476e56-a77a-4fcc-9823-49c03e333ccf"), "Кондитерка" },
                    { new Guid("47c22416-8d43-40cb-9c99-44ef42bb2061"), "Молочка" },
                    { new Guid("496fce3b-32d8-49ec-a2ed-a5711227ed0a"), "Термичка на ПЖП" },
                    { new Guid("5567e454-b246-4387-9195-a3ba05755e1a"), "Яйцо" },
                    { new Guid("6b4a63eb-3858-443b-a3cc-6dcf3d156d73"), "Вода" },
                    { new Guid("caba1ffc-f8f8-45f2-b283-4a1bf112152d"), "Орехи / Злаки / Семена" },
                    { new Guid("cb6d55ec-7500-45a2-bff5-d816bd7cd23f"), "Мясо" },
                    { new Guid("cde27ad4-5b03-4422-baec-97a818cfd236"), "Термичка растительная" },
                    { new Guid("dd6773b9-0fe2-4fb2-8f8c-597935af3681"), "Рыба / Морепродукты" },
                    { new Guid("ddb7a868-0c49-4f41-868e-f1bac5224849"), "Фрукты" },
                    { new Guid("de15d074-c2b3-43bc-af20-794ae3b7269d"), "Кофе" },
                    { new Guid("ed4d8728-1a5b-4f2c-a32f-c5f3b44599f6"), "Соки / Чай" },
                    { new Guid("fcb57ff1-21ec-42c3-9aa5-ccd6ef1f9bb1"), "Зелень / Овощи" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Guid", "Caloriers", "Carb", "Fat", "HarmScore", "Name", "Prot", "TrashPercentage" },
                values: new object[,]
                {
                    { new Guid("10aea75f-0a2d-4c6e-8ac6-9f39eb012eb3"), 576.0, 6.0, 49.0, 20.0, "Миндаль", 21.0, 0.0 },
                    { new Guid("1b007176-bc63-400e-b3f7-4826cc09a60c"), 61.0, 14.6, 0.5, 6.0, "Киви", 1.1000000000000001, 12.0 },
                    { new Guid("1e65c16c-fbe2-4c6a-a2c0-bab9f7e1f2ce"), 52.0, 11.4, 0.40000000000000002, 10.0, "Яблоко", 0.29999999999999999, 10.0 },
                    { new Guid("31f41442-82a0-4bba-9587-089c2cc51eec"), 208.0, 0.0, 14.300000000000001, 25.0, "Лосось", 20.0, 0.0 },
                    { new Guid("5401cd75-348d-4899-ac66-15f7fdf91e6b"), 96.0, 21.0, 0.20000000000000001, 10.0, "Банан", 1.0, 36.0 },
                    { new Guid("69380114-0c33-4faa-8a86-326d441d01e7"), 18.0, 3.8999999999999999, 0.20000000000000001, 5.0, "Томат", 0.90000000000000002, 5.0 },
                    { new Guid("81d352fc-d582-40cf-80bd-3e80f32f558e"), 57.0, 12.699999999999999, 0.10000000000000001, 7.0, "Груша", 0.40000000000000002, 3.0 },
                    { new Guid("89226c57-7e48-42b9-abac-6bc21ba7a85e"), 69.0, 17.600000000000001, 0.20000000000000001, 8.0, "Виноград", 0.59999999999999998, 10.0 },
                    { new Guid("b77aef8d-1d63-4a73-b3d9-5517036b06ea"), 59.0, 4.7000000000000002, 3.0, 15.0, "Йогурт", 3.5, 0.0 },
                    { new Guid("d971c99b-a519-4ba7-a078-2863c60f7f81"), 43.0, 8.1999999999999993, 0.20000000000000001, 5.0, "Апельсин", 0.90000000000000002, 40.0 }
                });

            migrationBuilder.InsertData(
                table: "WriteOffReasons",
                columns: new[] { "Guid", "ReasonName" },
                values: new object[,]
                {
                    { new Guid("32462b9c-293c-484c-a853-3fd48a4260d7"), "Несъедобная часть" },
                    { new Guid("46355abb-036f-4c9d-9690-5cf52b84195a"), "Угостил" },
                    { new Guid("6f7934dc-6e0e-4e19-9b7a-1cc0eeafe9e6"), "Испортился" },
                    { new Guid("e4f2790b-ab6e-49bf-840c-c139edd4913c"), "Потеря/усушка" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trashes_PurchaseGuid",
                table: "Trashes",
                column: "PurchaseGuid");

            migrationBuilder.CreateIndex(
                name: "IX_StorageProducts_PurchaseGuid",
                table: "StorageProducts",
                column: "PurchaseGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Consumptions_PurchaseGuid",
                table: "Consumptions",
                column: "PurchaseGuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumptions_Purchases_PurchaseGuid",
                table: "Consumptions",
                column: "PurchaseGuid",
                principalTable: "Purchases",
                principalColumn: "Guid");

            migrationBuilder.AddForeignKey(
                name: "FK_StorageProducts_Purchases_PurchaseGuid",
                table: "StorageProducts",
                column: "PurchaseGuid",
                principalTable: "Purchases",
                principalColumn: "Guid");

            migrationBuilder.AddForeignKey(
                name: "FK_Trashes_Purchases_PurchaseGuid",
                table: "Trashes",
                column: "PurchaseGuid",
                principalTable: "Purchases",
                principalColumn: "Guid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumptions_Purchases_PurchaseGuid",
                table: "Consumptions");

            migrationBuilder.DropForeignKey(
                name: "FK_StorageProducts_Purchases_PurchaseGuid",
                table: "StorageProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Trashes_Purchases_PurchaseGuid",
                table: "Trashes");

            migrationBuilder.DropIndex(
                name: "IX_Trashes_PurchaseGuid",
                table: "Trashes");

            migrationBuilder.DropIndex(
                name: "IX_StorageProducts_PurchaseGuid",
                table: "StorageProducts");

            migrationBuilder.DropIndex(
                name: "IX_Consumptions_PurchaseGuid",
                table: "Consumptions");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("01af66b3-fe59-4156-8d89-3635ef794718"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("0b476e56-a77a-4fcc-9823-49c03e333ccf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("47c22416-8d43-40cb-9c99-44ef42bb2061"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("496fce3b-32d8-49ec-a2ed-a5711227ed0a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("5567e454-b246-4387-9195-a3ba05755e1a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("6b4a63eb-3858-443b-a3cc-6dcf3d156d73"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("caba1ffc-f8f8-45f2-b283-4a1bf112152d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("cb6d55ec-7500-45a2-bff5-d816bd7cd23f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("cde27ad4-5b03-4422-baec-97a818cfd236"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("dd6773b9-0fe2-4fb2-8f8c-597935af3681"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("ddb7a868-0c49-4f41-868e-f1bac5224849"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("de15d074-c2b3-43bc-af20-794ae3b7269d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("ed4d8728-1a5b-4f2c-a32f-c5f3b44599f6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("fcb57ff1-21ec-42c3-9aa5-ccd6ef1f9bb1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("10aea75f-0a2d-4c6e-8ac6-9f39eb012eb3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("1b007176-bc63-400e-b3f7-4826cc09a60c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("1e65c16c-fbe2-4c6a-a2c0-bab9f7e1f2ce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("31f41442-82a0-4bba-9587-089c2cc51eec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("5401cd75-348d-4899-ac66-15f7fdf91e6b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("69380114-0c33-4faa-8a86-326d441d01e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("81d352fc-d582-40cf-80bd-3e80f32f558e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("89226c57-7e48-42b9-abac-6bc21ba7a85e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("b77aef8d-1d63-4a73-b3d9-5517036b06ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("d971c99b-a519-4ba7-a078-2863c60f7f81"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("32462b9c-293c-484c-a853-3fd48a4260d7"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("46355abb-036f-4c9d-9690-5cf52b84195a"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("6f7934dc-6e0e-4e19-9b7a-1cc0eeafe9e6"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("e4f2790b-ab6e-49bf-840c-c139edd4913c"));

            migrationBuilder.DropColumn(
                name: "PurchaseGuid",
                table: "Trashes");

            migrationBuilder.DropColumn(
                name: "SourceGuid",
                table: "Trashes");

            migrationBuilder.DropColumn(
                name: "PurchaseGuid",
                table: "StorageProducts");

            migrationBuilder.DropColumn(
                name: "PurchaseGuid",
                table: "Consumptions");

            migrationBuilder.DropColumn(
                name: "SourceGuid",
                table: "Consumptions");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Guid", "Name" },
                values: new object[,]
                {
                    { new Guid("03387044-19eb-476a-9cb4-7c86dd27d6af"), "Сухофрукты" },
                    { new Guid("0a0a5d72-0e7a-46e9-a4dd-c3347d4fde0a"), "Молочка" },
                    { new Guid("3e634cc4-d9c4-4ac3-9776-894aa1fdde1f"), "Кондитерка" },
                    { new Guid("6010096c-4205-4ddb-96bc-519ae1d5361a"), "Орехи / Злаки / Семена" },
                    { new Guid("62df2ecd-15b7-467e-ac27-d11587a6510a"), "Вода" },
                    { new Guid("6364bd27-21ee-4c7c-9ad2-dfb9569a773d"), "Яйцо" },
                    { new Guid("666107ba-a731-45c2-aa76-9f188ebb7933"), "Соки / Чай" },
                    { new Guid("78341d5c-1575-4d5f-9f36-538da49a1841"), "Фрукты" },
                    { new Guid("8ab2a91e-ccca-4b9e-9c74-aaad5add7959"), "Зелень / Овощи" },
                    { new Guid("be28a394-2056-47e4-a763-d375f2429d3b"), "Мясо" },
                    { new Guid("c7a769d4-1604-429f-b787-bbf14aea5463"), "Термичка на ПЖП" },
                    { new Guid("d47185ff-34fa-4978-a35f-4bbb1ec85af8"), "Кофе" },
                    { new Guid("e8b97d52-268e-47e0-a34c-d0c4c21baae1"), "Рыба / Морепродукты" },
                    { new Guid("fca20941-ad37-4490-92d4-b7370f96b610"), "Термичка растительная" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Guid", "Caloriers", "Carb", "Fat", "HarmScore", "Name", "Prot", "TrashPercentage" },
                values: new object[,]
                {
                    { new Guid("0a5aec3b-70a4-4073-836c-eb9d2c33061a"), 57.0, 12.699999999999999, 0.10000000000000001, 7.0, "Груша", 0.40000000000000002, 3.0 },
                    { new Guid("1198995d-7ecb-41a7-be77-b001716e44e4"), 576.0, 6.0, 49.0, 20.0, "Миндаль", 21.0, 0.0 },
                    { new Guid("4a427e74-037f-4b00-9563-47ed98f594f9"), 18.0, 3.8999999999999999, 0.20000000000000001, 5.0, "Томат", 0.90000000000000002, 5.0 },
                    { new Guid("54eff23a-f5ea-4b5e-9c1e-ee67a246dd81"), 61.0, 14.6, 0.5, 6.0, "Киви", 1.1000000000000001, 12.0 },
                    { new Guid("82230e1a-230e-4f8c-b0b3-17f865b9188f"), 69.0, 17.600000000000001, 0.20000000000000001, 8.0, "Виноград", 0.59999999999999998, 10.0 },
                    { new Guid("a0f59496-43d0-4921-bac9-e2555a25829e"), 52.0, 11.4, 0.40000000000000002, 10.0, "Яблоко", 0.29999999999999999, 10.0 },
                    { new Guid("d23f6ff7-9914-4fda-a6b0-a207e99f0061"), 96.0, 21.0, 0.20000000000000001, 10.0, "Банан", 1.0, 36.0 },
                    { new Guid("d8c0c59a-a04d-411b-a298-bd9ef516445f"), 208.0, 0.0, 14.300000000000001, 25.0, "Лосось", 20.0, 0.0 },
                    { new Guid("e0734383-313d-4182-bd4e-266a76f9c4a7"), 43.0, 8.1999999999999993, 0.20000000000000001, 5.0, "Апельсин", 0.90000000000000002, 40.0 },
                    { new Guid("fe468b74-e89a-4431-9724-40130c341c28"), 59.0, 4.7000000000000002, 3.0, 15.0, "Йогурт", 3.5, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "WriteOffReasons",
                columns: new[] { "Guid", "ReasonName" },
                values: new object[,]
                {
                    { new Guid("0ddf366a-24f3-4bbd-a349-e7f8591de5ca"), "Испортился" },
                    { new Guid("338694e7-12fc-46ae-85df-682623106403"), "Несъедобная часть" },
                    { new Guid("e0adb972-f0c0-44e8-a3c0-1c8387ea18d2"), "Угостил" },
                    { new Guid("f99b3b76-e67c-433d-b118-c9e01b77a16f"), "Потеря/усушка" }
                });
        }
    }
}
