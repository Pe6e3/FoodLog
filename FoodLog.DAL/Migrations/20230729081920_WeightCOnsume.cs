using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodLog.DAL.Migrations
{
    /// <inheritdoc />
    public partial class WeightCOnsume : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<double>(
                name: "WeightConsume",
                table: "StorageProducts",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "WeightRemainsAfter",
                table: "StorageProducts",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Guid", "Name" },
                values: new object[,]
                {
                    { new Guid("04275690-123e-46a3-af8f-9d8c52fcb7fa"), "Яйцо" },
                    { new Guid("0f2e1c7e-1f69-4d22-82f4-dda17e05d61b"), "Сухофрукты" },
                    { new Guid("1e712c7a-a5f0-4661-81c8-b2f0aaa1a66c"), "Зелень / Овощи" },
                    { new Guid("26caa1a3-095e-4541-8602-d46ffe2c1f67"), "Фрукты" },
                    { new Guid("5ea3fe22-50b1-42b1-a32d-fbd6d41dea4a"), "Соки / Чай" },
                    { new Guid("69b403a1-fb6d-4311-88d7-2e2df6385fab"), "Мясо" },
                    { new Guid("7b53f107-c082-46e3-8a9d-a91fa0ff4bdb"), "Орехи / Злаки / Семена" },
                    { new Guid("7f5435ea-c4c6-42f4-82ec-07d32f08f8b9"), "Молочка" },
                    { new Guid("893121e7-d4a8-43f9-8aa1-c0e617f7e508"), "Кофе" },
                    { new Guid("a27422c6-ac89-4b0c-a884-29961eca2942"), "Термичка на ПЖП" },
                    { new Guid("bf7e87d4-3eab-4c42-a974-85eae3045f06"), "Термичка растительная" },
                    { new Guid("c393dc6c-ab5e-4138-84dc-f59640d297d7"), "Рыба / Морепродукты" },
                    { new Guid("c4f16b0b-049a-42df-98e3-a40f3ae81964"), "Кондитерка" },
                    { new Guid("ef082047-b587-4ebb-b6f3-d03f10fbab11"), "Вода" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Guid", "Caloriers", "Carb", "Fat", "HarmScore", "Name", "Prot", "TrashPercentage" },
                values: new object[,]
                {
                    { new Guid("0e5c0fb6-c44b-4817-bbc4-3f35e363b70c"), 96.0, 21.0, 0.20000000000000001, 10.0, "Банан", 1.0, 36.0 },
                    { new Guid("18a3ae6f-09ed-46d6-ada1-7fdb5fb8699a"), 18.0, 3.8999999999999999, 0.20000000000000001, 5.0, "Томат", 0.90000000000000002, 5.0 },
                    { new Guid("481eb47f-7b68-4eba-bdd9-fd61bbb1b01e"), 576.0, 6.0, 49.0, 20.0, "Миндаль", 21.0, 0.0 },
                    { new Guid("7a22d82b-c7e6-4e80-8132-1e6cd489ab9f"), 52.0, 11.4, 0.40000000000000002, 10.0, "Яблоко", 0.29999999999999999, 10.0 },
                    { new Guid("860a9777-b739-4faf-9996-7d8b797e7400"), 208.0, 0.0, 14.300000000000001, 25.0, "Лосось", 20.0, 0.0 },
                    { new Guid("a1f2698c-4381-44e2-bf2c-8252a1697e11"), 69.0, 17.600000000000001, 0.20000000000000001, 8.0, "Виноград", 0.59999999999999998, 10.0 },
                    { new Guid("adc9e030-1513-444d-98b8-d6b7893a1eef"), 59.0, 4.7000000000000002, 3.0, 15.0, "Йогурт", 3.5, 0.0 },
                    { new Guid("ba4a04e0-b12d-4a99-9796-0eb1386fe483"), 61.0, 14.6, 0.5, 6.0, "Киви", 1.1000000000000001, 12.0 },
                    { new Guid("bbef3da8-6b83-4058-be71-ab6f46439ab3"), 43.0, 8.1999999999999993, 0.20000000000000001, 5.0, "Апельсин", 0.90000000000000002, 40.0 },
                    { new Guid("f5c3c036-40aa-4504-8c4c-fb796bf5ecdf"), 57.0, 12.699999999999999, 0.10000000000000001, 7.0, "Груша", 0.40000000000000002, 3.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("04275690-123e-46a3-af8f-9d8c52fcb7fa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("0f2e1c7e-1f69-4d22-82f4-dda17e05d61b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("1e712c7a-a5f0-4661-81c8-b2f0aaa1a66c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("26caa1a3-095e-4541-8602-d46ffe2c1f67"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("5ea3fe22-50b1-42b1-a32d-fbd6d41dea4a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("69b403a1-fb6d-4311-88d7-2e2df6385fab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("7b53f107-c082-46e3-8a9d-a91fa0ff4bdb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("7f5435ea-c4c6-42f4-82ec-07d32f08f8b9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("893121e7-d4a8-43f9-8aa1-c0e617f7e508"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("a27422c6-ac89-4b0c-a884-29961eca2942"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("bf7e87d4-3eab-4c42-a974-85eae3045f06"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("c393dc6c-ab5e-4138-84dc-f59640d297d7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("c4f16b0b-049a-42df-98e3-a40f3ae81964"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("ef082047-b587-4ebb-b6f3-d03f10fbab11"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("0e5c0fb6-c44b-4817-bbc4-3f35e363b70c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("18a3ae6f-09ed-46d6-ada1-7fdb5fb8699a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("481eb47f-7b68-4eba-bdd9-fd61bbb1b01e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("7a22d82b-c7e6-4e80-8132-1e6cd489ab9f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("860a9777-b739-4faf-9996-7d8b797e7400"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("a1f2698c-4381-44e2-bf2c-8252a1697e11"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("adc9e030-1513-444d-98b8-d6b7893a1eef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("ba4a04e0-b12d-4a99-9796-0eb1386fe483"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("bbef3da8-6b83-4058-be71-ab6f46439ab3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("f5c3c036-40aa-4504-8c4c-fb796bf5ecdf"));

            migrationBuilder.DropColumn(
                name: "WeightConsume",
                table: "StorageProducts");

            migrationBuilder.DropColumn(
                name: "WeightRemainsAfter",
                table: "StorageProducts");

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
    }
}
