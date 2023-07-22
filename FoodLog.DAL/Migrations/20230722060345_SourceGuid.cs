using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodLog.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SourceGuid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("0b180204-52e5-4d52-a632-785a0ae884e9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("0e2c2afc-c1ee-4fb3-be6a-be57fd1769e4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("185de742-b463-4710-a23d-22c0bc0387e9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("2078c0a3-7ab6-47c2-a2d8-f478ff1e6e17"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("3726bd39-beb7-44ab-91ca-a4c5de60c391"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("48dabd4f-8da8-467b-a5be-b71928d22521"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("5c62a052-82f9-45b1-9892-edf56fdaa043"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("6efb5723-1a3d-4776-b6fb-b34c19cdb852"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("7345f12f-d3ed-40ef-8167-97779018ab3a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("78117f12-9285-489c-9386-08e35ada6579"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("911cdf9f-ab03-4aea-82cb-0ad383fa02da"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("b3d49557-8bfd-43b3-af46-b98025207676"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("bee578de-d984-4228-b4e4-3891fae1a38e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("c87ac475-2386-458f-93c3-82b20fddf048"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("199d42df-f743-4aba-81eb-fceb18f8e21a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("25d15c60-fa8b-49fc-bf42-e7a8f9ebfcd5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("2cfab120-ce03-44c1-b0c4-aaafb005747c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("6e9905c8-a353-4cd0-b6f5-c6c1e4d5a5a3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("730cda8a-1853-4a71-a574-055be90870ce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("84896a67-1a40-4be5-afcd-600a4a01af40"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("9e276f1a-2460-4c24-b84c-9861bf720756"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("b066c396-7014-4123-9ad0-fbb2eb9eafef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("d735e46a-9d1c-440a-ac08-cd8362e00380"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("f7c4ebda-dba9-4a2c-b69e-ea443a25cf0a"));

            migrationBuilder.AddColumn<Guid>(
                name: "SourceGuid",
                table: "StorageProducts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "SourceGuid",
                table: "StorageProducts");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Guid", "Name" },
                values: new object[,]
                {
                    { new Guid("0b180204-52e5-4d52-a632-785a0ae884e9"), "Орехи / Злаки / Семена" },
                    { new Guid("0e2c2afc-c1ee-4fb3-be6a-be57fd1769e4"), "Кондитерка" },
                    { new Guid("185de742-b463-4710-a23d-22c0bc0387e9"), "Рыба / Морепродукты" },
                    { new Guid("2078c0a3-7ab6-47c2-a2d8-f478ff1e6e17"), "Молочка" },
                    { new Guid("3726bd39-beb7-44ab-91ca-a4c5de60c391"), "Термичка на ПЖП" },
                    { new Guid("48dabd4f-8da8-467b-a5be-b71928d22521"), "Фрукты" },
                    { new Guid("5c62a052-82f9-45b1-9892-edf56fdaa043"), "Мясо" },
                    { new Guid("6efb5723-1a3d-4776-b6fb-b34c19cdb852"), "Сухофрукты" },
                    { new Guid("7345f12f-d3ed-40ef-8167-97779018ab3a"), "Вода" },
                    { new Guid("78117f12-9285-489c-9386-08e35ada6579"), "Кофе" },
                    { new Guid("911cdf9f-ab03-4aea-82cb-0ad383fa02da"), "Зелень / Овощи" },
                    { new Guid("b3d49557-8bfd-43b3-af46-b98025207676"), "Яйцо" },
                    { new Guid("bee578de-d984-4228-b4e4-3891fae1a38e"), "Соки / Чай" },
                    { new Guid("c87ac475-2386-458f-93c3-82b20fddf048"), "Термичка растительная" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Guid", "Caloriers", "Carb", "Fat", "HarmScore", "Name", "Prot" },
                values: new object[,]
                {
                    { new Guid("199d42df-f743-4aba-81eb-fceb18f8e21a"), 52.0, 11.4, 0.40000000000000002, 10.0, "Яблоко", 0.29999999999999999 },
                    { new Guid("25d15c60-fa8b-49fc-bf42-e7a8f9ebfcd5"), 576.0, 6.0, 49.0, 20.0, "Миндаль", 21.0 },
                    { new Guid("2cfab120-ce03-44c1-b0c4-aaafb005747c"), 18.0, 3.8999999999999999, 0.20000000000000001, 5.0, "Томат", 0.90000000000000002 },
                    { new Guid("6e9905c8-a353-4cd0-b6f5-c6c1e4d5a5a3"), 59.0, 4.7000000000000002, 3.0, 15.0, "Йогурт", 3.5 },
                    { new Guid("730cda8a-1853-4a71-a574-055be90870ce"), 208.0, 0.0, 14.300000000000001, 25.0, "Лосось", 20.0 },
                    { new Guid("84896a67-1a40-4be5-afcd-600a4a01af40"), 96.0, 21.0, 0.20000000000000001, 10.0, "Банан", 1.0 },
                    { new Guid("9e276f1a-2460-4c24-b84c-9861bf720756"), 69.0, 17.600000000000001, 0.20000000000000001, 8.0, "Виноград", 0.59999999999999998 },
                    { new Guid("b066c396-7014-4123-9ad0-fbb2eb9eafef"), 43.0, 8.1999999999999993, 0.20000000000000001, 5.0, "Апельсин", 0.90000000000000002 },
                    { new Guid("d735e46a-9d1c-440a-ac08-cd8362e00380"), 57.0, 12.699999999999999, 0.10000000000000001, 7.0, "Груша", 0.40000000000000002 },
                    { new Guid("f7c4ebda-dba9-4a2c-b69e-ea443a25cf0a"), 61.0, 14.6, 0.5, 6.0, "Киви", 1.1000000000000001 }
                });
        }
    }
}
