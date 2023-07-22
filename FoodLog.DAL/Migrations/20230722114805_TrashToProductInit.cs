using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodLog.DAL.Migrations
{
    /// <inheritdoc />
    public partial class TrashToProductInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("02fef8d7-f271-4c5a-8049-8cacef962fcd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("040b8220-e4d3-456f-8b69-3218a09babf3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("2c78633a-7aa0-4e22-bbed-b59803a172f6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("49f65064-c2e1-4408-8c4b-905cfce8caa0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("619cf767-cb0b-4702-b3d7-5bdcf93c5249"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("7859bc18-20cd-404c-a017-24cf013de4b6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("7b603421-1164-4fde-9e84-b5b2db040527"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("83d57a96-b5f2-4d98-b35f-adf0ee79f7d9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("8a575b99-b5c0-456b-b079-27f8de80d2e0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("9eb87c00-cb7c-4e44-b7b1-010b48934634"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("ab543e54-6f44-4414-9415-e4c39d10744b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("bee6acb2-c34c-4cee-8de6-4bb747d3207c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("cc79a78b-f440-4804-a636-5e56e6c8c0a5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("d751ac0a-7873-43ea-876b-e70eadb153ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("182dd487-6c72-4ee7-a4ce-74d8ed546098"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("4e18a39b-ff44-486b-abad-e6616707aa91"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("4f196026-c778-4092-9cf9-2f1eda5c728d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("777d0d30-5e43-4d23-9e57-82ba5eb36680"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("98311e67-170f-4ea8-b959-78b3b9bd50f6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("e2bbaab1-1e1b-417f-83f9-7161890a9a61"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("e738ba3e-1093-4c1e-876f-ee89b187b29c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("e75b7faf-2bbd-4005-acfe-db455b0195a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("e9580667-80b6-46b8-b9fd-fe052ef79d1d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("f77c6bb1-61cd-4432-bb32-669971e6ab15"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Guid", "Name" },
                values: new object[,]
                {
                    { new Guid("050c5e19-5d8a-4237-b95c-44c607f347c7"), "Соки / Чай" },
                    { new Guid("2741cdca-14b5-493c-acf7-ebcef7609fc6"), "Термичка растительная" },
                    { new Guid("32f4c6db-3b55-4feb-ac38-c3414d576eb9"), "Зелень / Овощи" },
                    { new Guid("3467dc34-3e26-4761-87f4-4bc5d3894ba9"), "Яйцо" },
                    { new Guid("35653f61-532f-4b3e-ba7d-8378e1c41298"), "Молочка" },
                    { new Guid("4f81ec13-4baa-41d3-90a6-46d231e453f5"), "Вода" },
                    { new Guid("69a9dd6a-2f4c-42d7-8e85-e27d1c6fbc58"), "Сухофрукты" },
                    { new Guid("a1b23c2b-717c-4955-9ac2-0a784b45ae41"), "Термичка на ПЖП" },
                    { new Guid("af605676-3023-41e9-b74a-3be6bc0f9b2a"), "Рыба / Морепродукты" },
                    { new Guid("bc37afc4-37dc-4ac3-a8e8-f6dbf8269017"), "Кофе" },
                    { new Guid("c4d8e686-6b1b-4ec9-bac8-bd18d9cbde68"), "Фрукты" },
                    { new Guid("c4f96b08-f1da-44c9-83d9-62d4f9adda94"), "Кондитерка" },
                    { new Guid("e82153f3-d157-4801-8445-b000dc69f539"), "Мясо" },
                    { new Guid("f293b527-d3e9-4934-82b1-3e23cb5168f8"), "Орехи / Злаки / Семена" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Guid", "Caloriers", "Carb", "Fat", "HarmScore", "Name", "Prot", "TrashPercentage" },
                values: new object[,]
                {
                    { new Guid("0bd554bc-2d10-4e08-af76-dc4ff530e518"), 18.0, 3.8999999999999999, 0.20000000000000001, 5.0, "Томат", 0.90000000000000002, 5.0 },
                    { new Guid("52ed2ec6-8c30-4929-b36f-8b9cff514e4d"), 43.0, 8.1999999999999993, 0.20000000000000001, 5.0, "Апельсин", 0.90000000000000002, 40.0 },
                    { new Guid("5506d2f1-ac6b-43ab-b7cc-22eac527b9f9"), 52.0, 11.4, 0.40000000000000002, 10.0, "Яблоко", 0.29999999999999999, 10.0 },
                    { new Guid("6de915ea-438d-4dc4-bfff-ddbe5790fa6f"), 69.0, 17.600000000000001, 0.20000000000000001, 8.0, "Виноград", 0.59999999999999998, 10.0 },
                    { new Guid("85b796de-868c-45b5-bcb2-99afb4db0778"), 59.0, 4.7000000000000002, 3.0, 15.0, "Йогурт", 3.5, 0.0 },
                    { new Guid("c3606d3b-4b5a-436a-ac09-51ca26dfff01"), 57.0, 12.699999999999999, 0.10000000000000001, 7.0, "Груша", 0.40000000000000002, 3.0 },
                    { new Guid("c7caa6e3-ec69-437c-8f96-3eaeb7058a65"), 96.0, 21.0, 0.20000000000000001, 10.0, "Банан", 1.0, 36.0 },
                    { new Guid("e84f87c6-9a34-4916-951f-2218090dcde8"), 576.0, 6.0, 49.0, 20.0, "Миндаль", 21.0, 0.0 },
                    { new Guid("e9a7fdd4-a773-4fc6-82dd-43a4ecc9e153"), 208.0, 0.0, 14.300000000000001, 25.0, "Лосось", 20.0, 0.0 },
                    { new Guid("f858e891-8159-43f5-b104-c8e242119257"), 61.0, 14.6, 0.5, 6.0, "Киви", 1.1000000000000001, 12.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("050c5e19-5d8a-4237-b95c-44c607f347c7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("2741cdca-14b5-493c-acf7-ebcef7609fc6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("32f4c6db-3b55-4feb-ac38-c3414d576eb9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("3467dc34-3e26-4761-87f4-4bc5d3894ba9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("35653f61-532f-4b3e-ba7d-8378e1c41298"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("4f81ec13-4baa-41d3-90a6-46d231e453f5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("69a9dd6a-2f4c-42d7-8e85-e27d1c6fbc58"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("a1b23c2b-717c-4955-9ac2-0a784b45ae41"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("af605676-3023-41e9-b74a-3be6bc0f9b2a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("bc37afc4-37dc-4ac3-a8e8-f6dbf8269017"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("c4d8e686-6b1b-4ec9-bac8-bd18d9cbde68"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("c4f96b08-f1da-44c9-83d9-62d4f9adda94"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("e82153f3-d157-4801-8445-b000dc69f539"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("f293b527-d3e9-4934-82b1-3e23cb5168f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("0bd554bc-2d10-4e08-af76-dc4ff530e518"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("52ed2ec6-8c30-4929-b36f-8b9cff514e4d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("5506d2f1-ac6b-43ab-b7cc-22eac527b9f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("6de915ea-438d-4dc4-bfff-ddbe5790fa6f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("85b796de-868c-45b5-bcb2-99afb4db0778"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("c3606d3b-4b5a-436a-ac09-51ca26dfff01"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("c7caa6e3-ec69-437c-8f96-3eaeb7058a65"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("e84f87c6-9a34-4916-951f-2218090dcde8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("e9a7fdd4-a773-4fc6-82dd-43a4ecc9e153"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("f858e891-8159-43f5-b104-c8e242119257"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Guid", "Name" },
                values: new object[,]
                {
                    { new Guid("02fef8d7-f271-4c5a-8049-8cacef962fcd"), "Кофе" },
                    { new Guid("040b8220-e4d3-456f-8b69-3218a09babf3"), "Яйцо" },
                    { new Guid("2c78633a-7aa0-4e22-bbed-b59803a172f6"), "Термичка на ПЖП" },
                    { new Guid("49f65064-c2e1-4408-8c4b-905cfce8caa0"), "Молочка" },
                    { new Guid("619cf767-cb0b-4702-b3d7-5bdcf93c5249"), "Сухофрукты" },
                    { new Guid("7859bc18-20cd-404c-a017-24cf013de4b6"), "Фрукты" },
                    { new Guid("7b603421-1164-4fde-9e84-b5b2db040527"), "Орехи / Злаки / Семена" },
                    { new Guid("83d57a96-b5f2-4d98-b35f-adf0ee79f7d9"), "Соки / Чай" },
                    { new Guid("8a575b99-b5c0-456b-b079-27f8de80d2e0"), "Зелень / Овощи" },
                    { new Guid("9eb87c00-cb7c-4e44-b7b1-010b48934634"), "Вода" },
                    { new Guid("ab543e54-6f44-4414-9415-e4c39d10744b"), "Кондитерка" },
                    { new Guid("bee6acb2-c34c-4cee-8de6-4bb747d3207c"), "Рыба / Морепродукты" },
                    { new Guid("cc79a78b-f440-4804-a636-5e56e6c8c0a5"), "Мясо" },
                    { new Guid("d751ac0a-7873-43ea-876b-e70eadb153ae"), "Термичка растительная" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Guid", "Caloriers", "Carb", "Fat", "HarmScore", "Name", "Prot", "TrashPercentage" },
                values: new object[,]
                {
                    { new Guid("182dd487-6c72-4ee7-a4ce-74d8ed546098"), 59.0, 4.7000000000000002, 3.0, 15.0, "Йогурт", 3.5, 0.0 },
                    { new Guid("4e18a39b-ff44-486b-abad-e6616707aa91"), 69.0, 17.600000000000001, 0.20000000000000001, 8.0, "Виноград", 0.59999999999999998, 0.0 },
                    { new Guid("4f196026-c778-4092-9cf9-2f1eda5c728d"), 52.0, 11.4, 0.40000000000000002, 10.0, "Яблоко", 0.29999999999999999, 0.0 },
                    { new Guid("777d0d30-5e43-4d23-9e57-82ba5eb36680"), 96.0, 21.0, 0.20000000000000001, 10.0, "Банан", 1.0, 0.0 },
                    { new Guid("98311e67-170f-4ea8-b959-78b3b9bd50f6"), 18.0, 3.8999999999999999, 0.20000000000000001, 5.0, "Томат", 0.90000000000000002, 0.0 },
                    { new Guid("e2bbaab1-1e1b-417f-83f9-7161890a9a61"), 43.0, 8.1999999999999993, 0.20000000000000001, 5.0, "Апельсин", 0.90000000000000002, 0.0 },
                    { new Guid("e738ba3e-1093-4c1e-876f-ee89b187b29c"), 208.0, 0.0, 14.300000000000001, 25.0, "Лосось", 20.0, 0.0 },
                    { new Guid("e75b7faf-2bbd-4005-acfe-db455b0195a4"), 576.0, 6.0, 49.0, 20.0, "Миндаль", 21.0, 0.0 },
                    { new Guid("e9580667-80b6-46b8-b9fd-fe052ef79d1d"), 57.0, 12.699999999999999, 0.10000000000000001, 7.0, "Груша", 0.40000000000000002, 0.0 },
                    { new Guid("f77c6bb1-61cd-4432-bb32-669971e6ab15"), 61.0, 14.6, 0.5, 6.0, "Киви", 1.1000000000000001, 0.0 }
                });
        }
    }
}
