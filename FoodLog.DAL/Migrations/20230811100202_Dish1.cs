using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodLog.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Dish1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("07c78969-f5bb-4068-9015-8a72bae20a43"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("0f75939b-52a1-42d2-8733-955ffcfef745"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("14b98281-5bd2-437f-89c7-319f010cc139"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("234fb3d5-7f1e-45f4-837b-7a1f3481cee9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("23baa3ed-071d-4f84-9c72-63862b896547"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("38206c24-d635-4b04-9139-c37bc72e8545"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("40d96637-b7fd-4cdf-9d73-e9b793784e21"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("4f342060-ef44-4685-ad2c-ba5ae019419f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("6d5c5245-0bd6-4388-bebd-2027afabde66"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("72498c82-02ca-4d89-b31b-5f3ec3a99795"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("83575475-c98b-4d7e-a40f-cebe7527650a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("b3421f98-ce21-4432-96ef-9764fb2ce9f9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("b4f81e13-1d95-4f8f-864b-8fa739c3529a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("baa2ceae-130f-477a-8238-ae543438910e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("08404a72-21b0-4bbf-bdea-1ca067b31f83"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("67012f03-f4bb-4037-b54e-6cfbb27080cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("6dfc429a-5163-4dcb-8e0d-d0903fcf6579"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("862e7aec-de07-447c-a280-e4e1ddfd1d4e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("932d3943-7c05-4a8a-9f85-79b3d3edd768"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("a01eef5e-0010-4b02-84a7-7659fb4d1819"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("a8d35511-96d3-4483-8e38-c3c2779e7149"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("e12e3243-4320-4bad-b07e-24f93d31f2e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("ee06e4e0-1b3c-475c-b8f1-eb29005cd3d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("f3e2babe-ef45-481a-86cd-7f5a9fde4ce2"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("225b09a1-031e-49de-9c86-dd47a1e2af7b"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("76a12b60-6556-4fd5-8570-a98c1e91f80a"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("a34f0039-884f-4d18-8c8d-4972553d199f"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("c9a62be9-f680-4567-ab2f-3b5a9dcd3abc"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Guid", "Name" },
                values: new object[,]
                {
                    { new Guid("0b8bd9c8-a802-49e9-96c1-ff42eefe45f3"), "Термичка растительная" },
                    { new Guid("4a5a9b77-1bc2-4189-b1f9-8aaf2e8fe05c"), "Фрукты" },
                    { new Guid("4bb7e693-1e95-435d-a38d-0c6786ee862d"), "Соки / Чай" },
                    { new Guid("53b607f0-ca12-4a9a-b6fa-5b49be59ef03"), "Кондитерка" },
                    { new Guid("616943e1-4d33-463d-b51d-aaed5304c886"), "Зелень / Овощи" },
                    { new Guid("67440767-d1ed-4bdf-8f66-f05c62907565"), "Вода" },
                    { new Guid("70e0ff24-f2db-4a44-b60a-268e76335252"), "Яйцо" },
                    { new Guid("7a1552b8-96ed-40b6-86f7-bd17c61b688f"), "Мясо" },
                    { new Guid("8c98528f-6ad5-423f-84e8-13d7e0a2e454"), "Термичка на ПЖП" },
                    { new Guid("a794eadf-ef6c-4f31-9459-b00d4d3fd852"), "Кофе" },
                    { new Guid("a936dde1-57fa-4c9d-a29c-85473100e90c"), "Рыба / Морепродукты" },
                    { new Guid("d1367397-a7b7-4885-9368-87d6d479c282"), "Молочка" },
                    { new Guid("d9535f78-28f2-4f0a-9428-ca8c6de9d343"), "Сухофрукты" },
                    { new Guid("dba19c19-22a9-4d4c-98f9-182c23d05a48"), "Орехи / Злаки / Семена" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Guid", "Calories", "Carb", "DishGuid", "DishProductGuid", "Fat", "HarmScore", "Name", "Prot", "TrashPercentage" },
                values: new object[,]
                {
                    { new Guid("038676b2-b4c0-4f78-af6b-e3550ffec879"), 59.0, 4.7000000000000002, null, null, 3.0, 15.0, "Йогурт", 3.5, 0.0 },
                    { new Guid("21178440-7051-47f5-a8a8-4bbdb1d3e32a"), 69.0, 17.600000000000001, null, null, 0.20000000000000001, 8.0, "Виноград", 0.59999999999999998, 10.0 },
                    { new Guid("38320a45-d7ad-4908-9f21-8e5ea0c3effa"), 52.0, 11.4, null, null, 0.40000000000000002, 10.0, "Яблоко", 0.29999999999999999, 10.0 },
                    { new Guid("57903278-de82-4336-9ec9-2fdfdad7b1b7"), 576.0, 6.0, null, null, 49.0, 20.0, "Миндаль", 21.0, 0.0 },
                    { new Guid("634f16e2-33ab-43d2-a7a3-fd4825181164"), 61.0, 14.6, null, null, 0.5, 6.0, "Киви", 1.1000000000000001, 12.0 },
                    { new Guid("786896a5-229b-4910-8751-0efcc894af33"), 96.0, 21.0, null, null, 0.20000000000000001, 10.0, "Банан", 1.0, 36.0 },
                    { new Guid("84077209-b034-4c2d-b27a-dd280cef65bc"), 43.0, 8.1999999999999993, null, null, 0.20000000000000001, 5.0, "Апельсин", 0.90000000000000002, 40.0 },
                    { new Guid("a45d6d8f-b618-44ad-8d0c-9e46f27765f7"), 57.0, 12.699999999999999, null, null, 0.10000000000000001, 7.0, "Груша", 0.40000000000000002, 3.0 },
                    { new Guid("caf2eb25-f32c-4311-97a4-9b1c74f415a6"), 208.0, 0.0, null, null, 14.300000000000001, 25.0, "Лосось", 20.0, 0.0 },
                    { new Guid("fdffe773-5aa7-4374-9e43-0c0c410ff160"), 18.0, 3.8999999999999999, null, null, 0.20000000000000001, 5.0, "Томат", 0.90000000000000002, 5.0 }
                });

            migrationBuilder.InsertData(
                table: "WriteOffReasons",
                columns: new[] { "Guid", "ReasonName" },
                values: new object[,]
                {
                    { new Guid("5ffb1901-4f43-4e77-ad60-ddcc546c60ff"), "Несъедобная часть" },
                    { new Guid("b2bd0cc3-b0af-42fa-9f82-13b1f002c3c2"), "Угостил" },
                    { new Guid("ceb2f236-6d8f-4478-acdc-79c7f4dcc266"), "Потеря/усушка" },
                    { new Guid("d26f86b5-9b6a-4025-bfaf-cfbfd4c2eab3"), "Испортился" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("0b8bd9c8-a802-49e9-96c1-ff42eefe45f3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("4a5a9b77-1bc2-4189-b1f9-8aaf2e8fe05c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("4bb7e693-1e95-435d-a38d-0c6786ee862d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("53b607f0-ca12-4a9a-b6fa-5b49be59ef03"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("616943e1-4d33-463d-b51d-aaed5304c886"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("67440767-d1ed-4bdf-8f66-f05c62907565"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("70e0ff24-f2db-4a44-b60a-268e76335252"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("7a1552b8-96ed-40b6-86f7-bd17c61b688f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("8c98528f-6ad5-423f-84e8-13d7e0a2e454"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("a794eadf-ef6c-4f31-9459-b00d4d3fd852"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("a936dde1-57fa-4c9d-a29c-85473100e90c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("d1367397-a7b7-4885-9368-87d6d479c282"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("d9535f78-28f2-4f0a-9428-ca8c6de9d343"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("dba19c19-22a9-4d4c-98f9-182c23d05a48"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("038676b2-b4c0-4f78-af6b-e3550ffec879"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("21178440-7051-47f5-a8a8-4bbdb1d3e32a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("38320a45-d7ad-4908-9f21-8e5ea0c3effa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("57903278-de82-4336-9ec9-2fdfdad7b1b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("634f16e2-33ab-43d2-a7a3-fd4825181164"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("786896a5-229b-4910-8751-0efcc894af33"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("84077209-b034-4c2d-b27a-dd280cef65bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("a45d6d8f-b618-44ad-8d0c-9e46f27765f7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("caf2eb25-f32c-4311-97a4-9b1c74f415a6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fdffe773-5aa7-4374-9e43-0c0c410ff160"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("5ffb1901-4f43-4e77-ad60-ddcc546c60ff"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("b2bd0cc3-b0af-42fa-9f82-13b1f002c3c2"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("ceb2f236-6d8f-4478-acdc-79c7f4dcc266"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("d26f86b5-9b6a-4025-bfaf-cfbfd4c2eab3"));

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
        }
    }
}
