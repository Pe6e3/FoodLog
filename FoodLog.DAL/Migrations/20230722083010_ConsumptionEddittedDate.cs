using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodLog.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ConsumptionEddittedDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("06b71db8-0067-4c45-ab71-77ca5cf70f44"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("170f7f4d-edde-416c-a6af-8f4442cadd2e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("32cb150f-39f2-4767-bbf6-171ec5744192"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("44bc35db-dd34-4b8a-9362-3d470dc816f7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("5d4e2329-fd74-4924-bc30-58cfd6c910f6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("68aca51c-66f4-4e1d-ab5a-7dd00b33528c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("6a3c5531-b285-40bc-bfc8-5f256ce64f28"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("825a4a5b-bc2e-4fc4-89ba-208d962fe866"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("8bd52d6f-82e7-42ad-9379-a40da04c6f00"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("bd06fcfc-06f0-4ab6-92a8-d22ff3becc3e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("dea52a76-85c7-4cff-b8a0-3aa43f53ec01"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("e0e8ba67-943a-46b6-bdd5-c07a9a5693e0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("e267035a-ea9c-4ec6-b01e-82a2dfd30244"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("f3597f57-5af8-4340-9360-8ea28919a11f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("05f5736e-dbd5-40cf-ad7d-212e5ef86e10"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("0f862ea4-5309-4064-aa4a-4b47539d5a0c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("1daddefa-eeb2-403a-8d5a-fc6807e24ab9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("1df0406a-8cbd-4a24-b132-01e91697afa7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("8d9ec28f-79a0-4f2d-9010-566ba074cef2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("a013a466-04d6-425b-8d50-b005ea64fb4c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("b8940d17-7e5d-4281-b416-0ab93e9bbd5b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("d63c7fa8-6b4d-4976-9266-72fd0e3499b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("e02c8d8f-3a2e-4de2-a1a0-23eefa642244"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fab16db3-a3a7-43a2-9cf7-188a1635728f"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("06b71db8-0067-4c45-ab71-77ca5cf70f44"), "Кофе" },
                    { new Guid("170f7f4d-edde-416c-a6af-8f4442cadd2e"), "Мясо" },
                    { new Guid("32cb150f-39f2-4767-bbf6-171ec5744192"), "Молочка" },
                    { new Guid("44bc35db-dd34-4b8a-9362-3d470dc816f7"), "Термичка на ПЖП" },
                    { new Guid("5d4e2329-fd74-4924-bc30-58cfd6c910f6"), "Вода" },
                    { new Guid("68aca51c-66f4-4e1d-ab5a-7dd00b33528c"), "Сухофрукты" },
                    { new Guid("6a3c5531-b285-40bc-bfc8-5f256ce64f28"), "Орехи / Злаки / Семена" },
                    { new Guid("825a4a5b-bc2e-4fc4-89ba-208d962fe866"), "Термичка растительная" },
                    { new Guid("8bd52d6f-82e7-42ad-9379-a40da04c6f00"), "Яйцо" },
                    { new Guid("bd06fcfc-06f0-4ab6-92a8-d22ff3becc3e"), "Кондитерка" },
                    { new Guid("dea52a76-85c7-4cff-b8a0-3aa43f53ec01"), "Фрукты" },
                    { new Guid("e0e8ba67-943a-46b6-bdd5-c07a9a5693e0"), "Зелень / Овощи" },
                    { new Guid("e267035a-ea9c-4ec6-b01e-82a2dfd30244"), "Рыба / Морепродукты" },
                    { new Guid("f3597f57-5af8-4340-9360-8ea28919a11f"), "Соки / Чай" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Guid", "Caloriers", "Carb", "Fat", "HarmScore", "Name", "Prot" },
                values: new object[,]
                {
                    { new Guid("05f5736e-dbd5-40cf-ad7d-212e5ef86e10"), 52.0, 11.4, 0.40000000000000002, 10.0, "Яблоко", 0.29999999999999999 },
                    { new Guid("0f862ea4-5309-4064-aa4a-4b47539d5a0c"), 59.0, 4.7000000000000002, 3.0, 15.0, "Йогурт", 3.5 },
                    { new Guid("1daddefa-eeb2-403a-8d5a-fc6807e24ab9"), 43.0, 8.1999999999999993, 0.20000000000000001, 5.0, "Апельсин", 0.90000000000000002 },
                    { new Guid("1df0406a-8cbd-4a24-b132-01e91697afa7"), 57.0, 12.699999999999999, 0.10000000000000001, 7.0, "Груша", 0.40000000000000002 },
                    { new Guid("8d9ec28f-79a0-4f2d-9010-566ba074cef2"), 61.0, 14.6, 0.5, 6.0, "Киви", 1.1000000000000001 },
                    { new Guid("a013a466-04d6-425b-8d50-b005ea64fb4c"), 69.0, 17.600000000000001, 0.20000000000000001, 8.0, "Виноград", 0.59999999999999998 },
                    { new Guid("b8940d17-7e5d-4281-b416-0ab93e9bbd5b"), 96.0, 21.0, 0.20000000000000001, 10.0, "Банан", 1.0 },
                    { new Guid("d63c7fa8-6b4d-4976-9266-72fd0e3499b3"), 208.0, 0.0, 14.300000000000001, 25.0, "Лосось", 20.0 },
                    { new Guid("e02c8d8f-3a2e-4de2-a1a0-23eefa642244"), 18.0, 3.8999999999999999, 0.20000000000000001, 5.0, "Томат", 0.90000000000000002 },
                    { new Guid("fab16db3-a3a7-43a2-9cf7-188a1635728f"), 576.0, 6.0, 49.0, 20.0, "Миндаль", 21.0 }
                });
        }
    }
}
