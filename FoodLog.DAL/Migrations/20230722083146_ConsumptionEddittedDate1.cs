using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodLog.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ConsumptionEddittedDate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("07d1c8fa-8693-4ba9-aa92-0da99ef360c7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("109a169e-f9b6-4c4e-8a3c-0756fc95ca80"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("47d491a8-f343-45a0-8769-a24556c1bec2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("50d3269b-8b57-4bb3-82ff-d9dd3a0f29e2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("74e1b116-34d6-438d-9959-0578ba1e20ea"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("8c2ef9e1-7a33-4eb9-97c4-c9d1a3aa9fd7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("8d6bd380-3c93-4041-bc51-2b16b4ae9826"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("8dd9f79f-45e3-4f11-a0b0-3040f790d852"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("9c059dbf-73a3-418a-807f-d5b45743431f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("9d9c593d-dcaa-4a54-8ec9-ab0cc896055c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("a8b03780-c719-4dc7-bd04-8b9120f57d98"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("b8f47da6-79e2-4e13-8da1-f391c3476ca8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("e2645e94-0066-469c-9cdb-dbc4bf8f6b65"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("ef67ba62-3118-4887-aef0-bfc7a7378808"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("1c6363be-e2bd-4afe-98cc-c8c074ca2d21"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("44ba0048-44a5-47cd-8640-5cc1b2a6d1d9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("5b98a321-72d7-4f2d-96b0-d7000e3531f4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("63bd4bd8-2f3f-4b6f-b85a-20aef0264bec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("898ff465-fe27-451b-bed7-b002aea86f97"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("c64b81b9-fc4c-4cab-bc5b-dcf4f1886915"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("d09a065a-55ba-421f-aead-d49318774195"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("df186087-ce12-44a4-8ba4-9b3640b5ff42"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("eedbd4ef-dfb2-4c1f-b2e2-583e2d70d851"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fe68ff41-33d1-47ae-9e3f-e085d2ff17f2"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Guid", "Name" },
                values: new object[,]
                {
                    { new Guid("1b769573-9e4d-441c-9b45-ebf11ed78752"), "Вода" },
                    { new Guid("26ceb232-1356-45c5-8fb7-43430bce3017"), "Термичка растительная" },
                    { new Guid("3391cf38-ad05-4447-b62e-308b6443154a"), "Кондитерка" },
                    { new Guid("380b3515-1574-428b-86ea-f4b2ce929b49"), "Молочка" },
                    { new Guid("38596f96-0db6-42c3-9a08-7dbf3ac42cb3"), "Рыба / Морепродукты" },
                    { new Guid("4a07ae8f-b1c4-4c7c-88b0-1d3444b72044"), "Мясо" },
                    { new Guid("5bed2328-662e-4430-963e-5d163919a4e5"), "Орехи / Злаки / Семена" },
                    { new Guid("993fe1e7-8946-4921-bac0-8fc1ec2c105d"), "Фрукты" },
                    { new Guid("a5ac5444-8cb5-49ae-9e36-2b4c393df02d"), "Яйцо" },
                    { new Guid("a84c6fe9-a689-435b-b29d-ba3650e17102"), "Соки / Чай" },
                    { new Guid("b359abb3-e9f2-4937-a15e-784a637c91b9"), "Термичка на ПЖП" },
                    { new Guid("d6eb2e31-1767-4899-96a0-c9dd884d2b4f"), "Кофе" },
                    { new Guid("da829d2d-78da-4bca-9042-a1ba4bef34ac"), "Зелень / Овощи" },
                    { new Guid("fdec60f7-4d03-4a6b-b6cc-0ab4ba97d5cf"), "Сухофрукты" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Guid", "Caloriers", "Carb", "Fat", "HarmScore", "Name", "Prot" },
                values: new object[,]
                {
                    { new Guid("2b5db54e-5c2c-4dcc-bf0f-3d6bb5c59095"), 208.0, 0.0, 14.300000000000001, 25.0, "Лосось", 20.0 },
                    { new Guid("32a10e87-49fe-4b28-b7f2-a14c0c237946"), 61.0, 14.6, 0.5, 6.0, "Киви", 1.1000000000000001 },
                    { new Guid("45b6ae1a-0323-44bb-b110-0020e48d94cc"), 43.0, 8.1999999999999993, 0.20000000000000001, 5.0, "Апельсин", 0.90000000000000002 },
                    { new Guid("84696186-6697-49de-8844-42ad8347fd15"), 69.0, 17.600000000000001, 0.20000000000000001, 8.0, "Виноград", 0.59999999999999998 },
                    { new Guid("9a12113b-b5e8-4ce5-bcba-f469bc62fb58"), 59.0, 4.7000000000000002, 3.0, 15.0, "Йогурт", 3.5 },
                    { new Guid("9bcc4f3a-d20a-480a-aa63-23f1a298c515"), 18.0, 3.8999999999999999, 0.20000000000000001, 5.0, "Томат", 0.90000000000000002 },
                    { new Guid("acdd3326-7cd1-47d1-a181-bf13cd976a74"), 52.0, 11.4, 0.40000000000000002, 10.0, "Яблоко", 0.29999999999999999 },
                    { new Guid("ad0df4d9-eec2-4fe3-9656-44427eb27d6a"), 57.0, 12.699999999999999, 0.10000000000000001, 7.0, "Груша", 0.40000000000000002 },
                    { new Guid("cd3a90bc-6cb8-4733-b15f-ce0401a08a89"), 96.0, 21.0, 0.20000000000000001, 10.0, "Банан", 1.0 },
                    { new Guid("ef16d6da-9a1b-487b-bfed-6226f82243f6"), 576.0, 6.0, 49.0, 20.0, "Миндаль", 21.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("1b769573-9e4d-441c-9b45-ebf11ed78752"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("26ceb232-1356-45c5-8fb7-43430bce3017"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("3391cf38-ad05-4447-b62e-308b6443154a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("380b3515-1574-428b-86ea-f4b2ce929b49"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("38596f96-0db6-42c3-9a08-7dbf3ac42cb3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("4a07ae8f-b1c4-4c7c-88b0-1d3444b72044"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("5bed2328-662e-4430-963e-5d163919a4e5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("993fe1e7-8946-4921-bac0-8fc1ec2c105d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("a5ac5444-8cb5-49ae-9e36-2b4c393df02d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("a84c6fe9-a689-435b-b29d-ba3650e17102"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("b359abb3-e9f2-4937-a15e-784a637c91b9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("d6eb2e31-1767-4899-96a0-c9dd884d2b4f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("da829d2d-78da-4bca-9042-a1ba4bef34ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("fdec60f7-4d03-4a6b-b6cc-0ab4ba97d5cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("2b5db54e-5c2c-4dcc-bf0f-3d6bb5c59095"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("32a10e87-49fe-4b28-b7f2-a14c0c237946"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("45b6ae1a-0323-44bb-b110-0020e48d94cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("84696186-6697-49de-8844-42ad8347fd15"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("9a12113b-b5e8-4ce5-bcba-f469bc62fb58"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("9bcc4f3a-d20a-480a-aa63-23f1a298c515"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("acdd3326-7cd1-47d1-a181-bf13cd976a74"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("ad0df4d9-eec2-4fe3-9656-44427eb27d6a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("cd3a90bc-6cb8-4733-b15f-ce0401a08a89"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("ef16d6da-9a1b-487b-bfed-6226f82243f6"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Guid", "Name" },
                values: new object[,]
                {
                    { new Guid("07d1c8fa-8693-4ba9-aa92-0da99ef360c7"), "Вода" },
                    { new Guid("109a169e-f9b6-4c4e-8a3c-0756fc95ca80"), "Кофе" },
                    { new Guid("47d491a8-f343-45a0-8769-a24556c1bec2"), "Термичка на ПЖП" },
                    { new Guid("50d3269b-8b57-4bb3-82ff-d9dd3a0f29e2"), "Фрукты" },
                    { new Guid("74e1b116-34d6-438d-9959-0578ba1e20ea"), "Термичка растительная" },
                    { new Guid("8c2ef9e1-7a33-4eb9-97c4-c9d1a3aa9fd7"), "Сухофрукты" },
                    { new Guid("8d6bd380-3c93-4041-bc51-2b16b4ae9826"), "Молочка" },
                    { new Guid("8dd9f79f-45e3-4f11-a0b0-3040f790d852"), "Орехи / Злаки / Семена" },
                    { new Guid("9c059dbf-73a3-418a-807f-d5b45743431f"), "Кондитерка" },
                    { new Guid("9d9c593d-dcaa-4a54-8ec9-ab0cc896055c"), "Мясо" },
                    { new Guid("a8b03780-c719-4dc7-bd04-8b9120f57d98"), "Зелень / Овощи" },
                    { new Guid("b8f47da6-79e2-4e13-8da1-f391c3476ca8"), "Соки / Чай" },
                    { new Guid("e2645e94-0066-469c-9cdb-dbc4bf8f6b65"), "Яйцо" },
                    { new Guid("ef67ba62-3118-4887-aef0-bfc7a7378808"), "Рыба / Морепродукты" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Guid", "Caloriers", "Carb", "Fat", "HarmScore", "Name", "Prot" },
                values: new object[,]
                {
                    { new Guid("1c6363be-e2bd-4afe-98cc-c8c074ca2d21"), 43.0, 8.1999999999999993, 0.20000000000000001, 5.0, "Апельсин", 0.90000000000000002 },
                    { new Guid("44ba0048-44a5-47cd-8640-5cc1b2a6d1d9"), 61.0, 14.6, 0.5, 6.0, "Киви", 1.1000000000000001 },
                    { new Guid("5b98a321-72d7-4f2d-96b0-d7000e3531f4"), 57.0, 12.699999999999999, 0.10000000000000001, 7.0, "Груша", 0.40000000000000002 },
                    { new Guid("63bd4bd8-2f3f-4b6f-b85a-20aef0264bec"), 18.0, 3.8999999999999999, 0.20000000000000001, 5.0, "Томат", 0.90000000000000002 },
                    { new Guid("898ff465-fe27-451b-bed7-b002aea86f97"), 576.0, 6.0, 49.0, 20.0, "Миндаль", 21.0 },
                    { new Guid("c64b81b9-fc4c-4cab-bc5b-dcf4f1886915"), 96.0, 21.0, 0.20000000000000001, 10.0, "Банан", 1.0 },
                    { new Guid("d09a065a-55ba-421f-aead-d49318774195"), 59.0, 4.7000000000000002, 3.0, 15.0, "Йогурт", 3.5 },
                    { new Guid("df186087-ce12-44a4-8ba4-9b3640b5ff42"), 69.0, 17.600000000000001, 0.20000000000000001, 8.0, "Виноград", 0.59999999999999998 },
                    { new Guid("eedbd4ef-dfb2-4c1f-b2e2-583e2d70d851"), 52.0, 11.4, 0.40000000000000002, 10.0, "Яблоко", 0.29999999999999999 },
                    { new Guid("fe68ff41-33d1-47ae-9e3f-e085d2ff17f2"), 208.0, 0.0, 14.300000000000001, 25.0, "Лосось", 20.0 }
                });
        }
    }
}
