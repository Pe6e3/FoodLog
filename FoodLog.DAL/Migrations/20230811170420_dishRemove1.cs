using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodLog.DAL.Migrations
{
    /// <inheritdoc />
    public partial class dishRemove1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("0099f266-dad2-4f16-aaf4-b63bfcc13e92"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("067311d4-d36d-494c-99a4-f54a2bded07f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("0a4d823f-30d8-42b5-bd11-80ab2a9c9c46"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("0d064621-9e33-49e0-9e09-2ef927b440d5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("4ddc0ce3-2bdc-4d39-866a-4a192d2ec68d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("53567ccd-3f73-4975-9408-b80989a5c385"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("54903d38-39b0-4829-9c8f-cc2a494dd58d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("62865e82-3da2-4974-b1d6-d4c160ddacb4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("64b1d037-a7ea-4c42-9992-e9925e9f07a0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("6feba93e-8b5d-4f97-97bd-29d22b903666"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("86ba7961-f8c2-4ba5-aa52-2d8bb86cf416"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("87b29600-86ca-4798-a6fb-3bc44ffdac59"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("b7f6a38c-0262-492c-8296-80485da142f9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("bc6a6a7e-dcd3-4bf7-a2e8-ca7eca136f06"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("29c8e516-f251-450a-9cbd-c98b0d29d0a5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("53a73521-7c76-4ca1-82bf-6127d78d23e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("5bd81539-0eff-4e13-ad95-f194db444820"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("7cad76e2-4713-4791-a8ba-8da88091ed0f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("7fde6071-0ad6-47b1-8a9f-bfa48c2116f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("c541d0b3-bd04-4156-a37a-030bd337854b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("d2991858-5424-4c62-804d-a296ac4361eb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("ea977f6c-f848-4f7f-b2d6-e947fab1668f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("eb5abca4-238e-42d7-921f-a0fc969458ab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("fb95ffbf-b040-424c-a84e-d00ad303e5a9"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("0055bc91-aa84-49d2-9dfe-1e520172543a"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("3984671d-7a64-4bad-b050-cdc70207a03f"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("a3d1db6e-c9fc-4453-9853-908f50fe8609"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("c4536722-b2d9-46be-b9b5-596731f34cf2"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Guid", "Name" },
                values: new object[,]
                {
                    { new Guid("0bb858f2-903c-4519-9abe-d819b36cf3dc"), "Зелень / Овощи" },
                    { new Guid("10a65b65-c114-4a73-a916-478a921e25f1"), "Вода" },
                    { new Guid("25c23a2f-8e6c-4bf2-b3b2-4ce08737dd4d"), "Кондитерка" },
                    { new Guid("2f7986df-2c0a-4bec-a5fa-18a310636c73"), "Термичка на ПЖП" },
                    { new Guid("560937a9-2713-435e-baf1-40e4dff68a3e"), "Орехи / Злаки / Семена" },
                    { new Guid("5a23138d-0176-417c-88f1-998ce28bf194"), "Кофе" },
                    { new Guid("642ae78a-c01e-4fd8-bf05-25567df7be72"), "Молочка" },
                    { new Guid("8bc5a6f3-cb8b-43b3-a8a1-c51654d68ad3"), "Мясо" },
                    { new Guid("ac45a8a7-194a-44f2-b052-de05f9550cdd"), "Соки / Чай" },
                    { new Guid("ace5d611-6c58-405b-89d9-683ad0254e9c"), "Яйцо" },
                    { new Guid("b97ea0e5-05a2-4c2c-8df1-ec33921e6d8e"), "Сухофрукты" },
                    { new Guid("c3299add-00a2-451b-b2bc-23f3a0537729"), "Рыба / Морепродукты" },
                    { new Guid("c3df00b9-389c-4413-84ae-7e1ce41aace8"), "Термичка растительная" },
                    { new Guid("e7064f54-3a0d-41b4-8c5a-aa09244b7f8a"), "Фрукты" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Guid", "Calories", "Carb", "DishGuid", "DishProductGuid", "Fat", "HarmScore", "Name", "Prot", "TrashPercentage" },
                values: new object[,]
                {
                    { new Guid("19c72aca-5eb9-45fa-b9e8-5c4c92cc022b"), 43.0, 8.1999999999999993, null, null, 0.20000000000000001, 5.0, "Апельсин", 0.90000000000000002, 40.0 },
                    { new Guid("33ec46c0-82b1-4fb7-9db4-c8368cb6dc8f"), 61.0, 14.6, null, null, 0.5, 6.0, "Киви", 1.1000000000000001, 12.0 },
                    { new Guid("40539843-8333-4fe5-acd0-68167ae551a6"), 576.0, 6.0, null, null, 49.0, 20.0, "Миндаль", 21.0, 0.0 },
                    { new Guid("46f0dcbe-0780-4f84-8bb0-02cd937d31c0"), 59.0, 4.7000000000000002, null, null, 3.0, 15.0, "Йогурт", 3.5, 0.0 },
                    { new Guid("4c49007c-30fe-4084-ad15-f0f9fc8d1c7a"), 57.0, 12.699999999999999, null, null, 0.10000000000000001, 7.0, "Груша", 0.40000000000000002, 3.0 },
                    { new Guid("51bf85df-10a9-4532-a269-cd44ce676fe4"), 96.0, 21.0, null, null, 0.20000000000000001, 10.0, "Банан", 1.0, 36.0 },
                    { new Guid("a270a048-a253-4ca6-8463-1825aab6ebaa"), 52.0, 11.4, null, null, 0.40000000000000002, 10.0, "Яблоко", 0.29999999999999999, 10.0 },
                    { new Guid("c8a26c9d-d4f4-45fa-8e60-14d5c7f69987"), 69.0, 17.600000000000001, null, null, 0.20000000000000001, 8.0, "Виноград", 0.59999999999999998, 10.0 },
                    { new Guid("e4f57ded-9f95-4545-b49d-503eeeee2fed"), 18.0, 3.8999999999999999, null, null, 0.20000000000000001, 5.0, "Томат", 0.90000000000000002, 5.0 },
                    { new Guid("e9552b49-5ec1-4e8d-b625-7afe603e1dfb"), 208.0, 0.0, null, null, 14.300000000000001, 25.0, "Лосось", 20.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "WriteOffReasons",
                columns: new[] { "Guid", "ReasonName" },
                values: new object[,]
                {
                    { new Guid("1fc1df08-9ebe-48aa-ae43-216c56300db4"), "Несъедобная часть" },
                    { new Guid("39a240ac-5059-4672-bbcf-f52aa286c7e3"), "Испортился" },
                    { new Guid("8b89a406-64ce-45be-8f04-26e785072a37"), "Угостил" },
                    { new Guid("c65def71-475b-4697-93ea-6c9775b4826d"), "Потеря/усушка" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("0bb858f2-903c-4519-9abe-d819b36cf3dc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("10a65b65-c114-4a73-a916-478a921e25f1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("25c23a2f-8e6c-4bf2-b3b2-4ce08737dd4d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("2f7986df-2c0a-4bec-a5fa-18a310636c73"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("560937a9-2713-435e-baf1-40e4dff68a3e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("5a23138d-0176-417c-88f1-998ce28bf194"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("642ae78a-c01e-4fd8-bf05-25567df7be72"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("8bc5a6f3-cb8b-43b3-a8a1-c51654d68ad3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("ac45a8a7-194a-44f2-b052-de05f9550cdd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("ace5d611-6c58-405b-89d9-683ad0254e9c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("b97ea0e5-05a2-4c2c-8df1-ec33921e6d8e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("c3299add-00a2-451b-b2bc-23f3a0537729"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("c3df00b9-389c-4413-84ae-7e1ce41aace8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("e7064f54-3a0d-41b4-8c5a-aa09244b7f8a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("19c72aca-5eb9-45fa-b9e8-5c4c92cc022b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("33ec46c0-82b1-4fb7-9db4-c8368cb6dc8f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("40539843-8333-4fe5-acd0-68167ae551a6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("46f0dcbe-0780-4f84-8bb0-02cd937d31c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("4c49007c-30fe-4084-ad15-f0f9fc8d1c7a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("51bf85df-10a9-4532-a269-cd44ce676fe4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("a270a048-a253-4ca6-8463-1825aab6ebaa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("c8a26c9d-d4f4-45fa-8e60-14d5c7f69987"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("e4f57ded-9f95-4545-b49d-503eeeee2fed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("e9552b49-5ec1-4e8d-b625-7afe603e1dfb"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("1fc1df08-9ebe-48aa-ae43-216c56300db4"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("39a240ac-5059-4672-bbcf-f52aa286c7e3"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("8b89a406-64ce-45be-8f04-26e785072a37"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("c65def71-475b-4697-93ea-6c9775b4826d"));

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
        }
    }
}
