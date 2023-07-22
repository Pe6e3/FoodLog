using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodLog.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ConsumptionEdditted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("1235468b-6a4d-4a6a-8780-20be52794b2a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("2b710487-7d77-456a-9d7c-691d4f3ddbb9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("2bccdb06-330d-4c52-abfb-b27bb3fe43d8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("2eefed66-b7d3-4d63-9c99-b858a048c126"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("3774bb67-2771-464d-bcd3-de2e6a5e5ce9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("54b4d492-5035-44c6-8645-5d878bf3be57"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("5df4d080-3446-4600-8258-a1fc65c906d4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("81eb258a-dd83-404f-8c04-592f3d95d68a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("99358e76-51b6-4661-ab7a-e8a1c640e1cc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("c1b3a5b9-887a-4088-8673-33721c8ed038"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("c9d04a89-7a39-415d-9b33-f73995006cca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("d99eb0ce-e3b6-4e2e-b789-dccf728b4b98"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("eb0c0936-75c5-4b6c-91ed-18602f4d321d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("f810d8e0-abd3-4c4f-89d9-38c191ebca61"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("1fb44983-3ef0-424f-9feb-26521ba48ee4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("46b4890f-5401-43ea-b739-8a73ce2d4dba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("46bd4abb-20d9-47f2-9f95-3e6412f73539"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("6707428c-e7da-4d66-b32f-447ba382fc08"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("7316d492-a766-427e-a3a8-5cb94936888b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("931ba37c-2c9b-4cd9-9039-998c68df6664"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("ad6658d8-4b97-49eb-bfc0-aedc98662168"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("c2c03f81-d3b9-4f30-9e93-21a5800b7556"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("ee5366df-f726-4333-99b8-183375148e5c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fcf5c99f-a91a-4f3f-bf42-0369872be73e"));

            migrationBuilder.DropColumn(
                name: "Caloriers",
                table: "Consumptions");

            migrationBuilder.DropColumn(
                name: "Carb",
                table: "Consumptions");

            migrationBuilder.DropColumn(
                name: "Fat",
                table: "Consumptions");

            migrationBuilder.DropColumn(
                name: "HarmScore",
                table: "Consumptions");

            migrationBuilder.DropColumn(
                name: "Prot",
                table: "Consumptions");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<double>(
                name: "Caloriers",
                table: "Consumptions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Carb",
                table: "Consumptions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Fat",
                table: "Consumptions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "HarmScore",
                table: "Consumptions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Prot",
                table: "Consumptions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Guid", "Name" },
                values: new object[,]
                {
                    { new Guid("1235468b-6a4d-4a6a-8780-20be52794b2a"), "Орехи / Злаки / Семена" },
                    { new Guid("2b710487-7d77-456a-9d7c-691d4f3ddbb9"), "Фрукты" },
                    { new Guid("2bccdb06-330d-4c52-abfb-b27bb3fe43d8"), "Термичка на ПЖП" },
                    { new Guid("2eefed66-b7d3-4d63-9c99-b858a048c126"), "Молочка" },
                    { new Guid("3774bb67-2771-464d-bcd3-de2e6a5e5ce9"), "Кондитерка" },
                    { new Guid("54b4d492-5035-44c6-8645-5d878bf3be57"), "Зелень / Овощи" },
                    { new Guid("5df4d080-3446-4600-8258-a1fc65c906d4"), "Мясо" },
                    { new Guid("81eb258a-dd83-404f-8c04-592f3d95d68a"), "Кофе" },
                    { new Guid("99358e76-51b6-4661-ab7a-e8a1c640e1cc"), "Вода" },
                    { new Guid("c1b3a5b9-887a-4088-8673-33721c8ed038"), "Сухофрукты" },
                    { new Guid("c9d04a89-7a39-415d-9b33-f73995006cca"), "Соки / Чай" },
                    { new Guid("d99eb0ce-e3b6-4e2e-b789-dccf728b4b98"), "Рыба / Морепродукты" },
                    { new Guid("eb0c0936-75c5-4b6c-91ed-18602f4d321d"), "Термичка растительная" },
                    { new Guid("f810d8e0-abd3-4c4f-89d9-38c191ebca61"), "Яйцо" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Guid", "Caloriers", "Carb", "Fat", "HarmScore", "Name", "Prot" },
                values: new object[,]
                {
                    { new Guid("1fb44983-3ef0-424f-9feb-26521ba48ee4"), 52.0, 11.4, 0.40000000000000002, 10.0, "Яблоко", 0.29999999999999999 },
                    { new Guid("46b4890f-5401-43ea-b739-8a73ce2d4dba"), 57.0, 12.699999999999999, 0.10000000000000001, 7.0, "Груша", 0.40000000000000002 },
                    { new Guid("46bd4abb-20d9-47f2-9f95-3e6412f73539"), 43.0, 8.1999999999999993, 0.20000000000000001, 5.0, "Апельсин", 0.90000000000000002 },
                    { new Guid("6707428c-e7da-4d66-b32f-447ba382fc08"), 18.0, 3.8999999999999999, 0.20000000000000001, 5.0, "Томат", 0.90000000000000002 },
                    { new Guid("7316d492-a766-427e-a3a8-5cb94936888b"), 61.0, 14.6, 0.5, 6.0, "Киви", 1.1000000000000001 },
                    { new Guid("931ba37c-2c9b-4cd9-9039-998c68df6664"), 576.0, 6.0, 49.0, 20.0, "Миндаль", 21.0 },
                    { new Guid("ad6658d8-4b97-49eb-bfc0-aedc98662168"), 69.0, 17.600000000000001, 0.20000000000000001, 8.0, "Виноград", 0.59999999999999998 },
                    { new Guid("c2c03f81-d3b9-4f30-9e93-21a5800b7556"), 208.0, 0.0, 14.300000000000001, 25.0, "Лосось", 20.0 },
                    { new Guid("ee5366df-f726-4333-99b8-183375148e5c"), 96.0, 21.0, 0.20000000000000001, 10.0, "Банан", 1.0 },
                    { new Guid("fcf5c99f-a91a-4f3f-bf42-0369872be73e"), 59.0, 4.7000000000000002, 3.0, 15.0, "Йогурт", 3.5 }
                });
        }
    }
}
