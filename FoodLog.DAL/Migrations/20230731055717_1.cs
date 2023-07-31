using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodLog.DAL.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "TrashPercentage",
                table: "Consumptions");

            migrationBuilder.DropColumn(
                name: "TrashWeight",
                table: "Consumptions");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Guid", "Name" },
                values: new object[,]
                {
                    { new Guid("03b522b9-210a-4faf-a9b7-7a361b754e6b"), "Сухофрукты" },
                    { new Guid("17c60770-bf83-4352-a02d-5b5d264a8478"), "Кофе" },
                    { new Guid("2a39268e-f031-4656-b2ca-27d5c71d91bb"), "Термичка на ПЖП" },
                    { new Guid("3d034664-4d20-47ff-894b-6f8b418ddcef"), "Орехи / Злаки / Семена" },
                    { new Guid("47882663-9b1f-47c8-9fdc-746cf211332c"), "Термичка растительная" },
                    { new Guid("528658b5-5540-4e2d-9fa2-bfc7a179be1c"), "Мясо" },
                    { new Guid("54592414-12ad-415a-9b43-1c494968270d"), "Яйцо" },
                    { new Guid("64fa9ecb-7921-4ca7-9553-0bf9c067c382"), "Кондитерка" },
                    { new Guid("728e88f6-cc6f-4c6c-8596-2aa7ec1cf101"), "Молочка" },
                    { new Guid("ae1ffb60-b121-4bc2-bf23-05aaa2776bc5"), "Зелень / Овощи" },
                    { new Guid("b9dff157-9b81-45c7-a3ec-86b8de4670b1"), "Соки / Чай" },
                    { new Guid("cce45639-8723-499e-8c81-ba8485ee590b"), "Вода" },
                    { new Guid("e79b935e-6874-497a-af63-40cd590e67ca"), "Рыба / Морепродукты" },
                    { new Guid("fdd8d62c-62fc-45ab-8aa5-8dffc880b98d"), "Фрукты" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Guid", "Caloriers", "Carb", "Fat", "HarmScore", "Name", "Prot", "TrashPercentage" },
                values: new object[,]
                {
                    { new Guid("00cc3f3f-922f-497e-a6f0-fa2104bc1df5"), 96.0, 21.0, 0.20000000000000001, 10.0, "Банан", 1.0, 36.0 },
                    { new Guid("186d4b86-711f-4931-985c-d465cf060598"), 59.0, 4.7000000000000002, 3.0, 15.0, "Йогурт", 3.5, 0.0 },
                    { new Guid("259b3583-ffb0-4820-a794-b2119d2f0777"), 18.0, 3.8999999999999999, 0.20000000000000001, 5.0, "Томат", 0.90000000000000002, 5.0 },
                    { new Guid("26e13a47-b669-4e0c-99af-c10528120f52"), 57.0, 12.699999999999999, 0.10000000000000001, 7.0, "Груша", 0.40000000000000002, 3.0 },
                    { new Guid("4ab9ffca-c8e7-43b1-8678-7753ceab2918"), 61.0, 14.6, 0.5, 6.0, "Киви", 1.1000000000000001, 12.0 },
                    { new Guid("742a9f79-1a21-4ea9-ac8b-e99cc63cc0f0"), 43.0, 8.1999999999999993, 0.20000000000000001, 5.0, "Апельсин", 0.90000000000000002, 40.0 },
                    { new Guid("b350504a-19c4-46ad-8cf2-a817eb86ccc8"), 208.0, 0.0, 14.300000000000001, 25.0, "Лосось", 20.0, 0.0 },
                    { new Guid("d3552b31-058c-45a2-95e1-1233f392c84a"), 576.0, 6.0, 49.0, 20.0, "Миндаль", 21.0, 0.0 },
                    { new Guid("de7c1324-4917-440a-92b3-baa240fed066"), 52.0, 11.4, 0.40000000000000002, 10.0, "Яблоко", 0.29999999999999999, 10.0 },
                    { new Guid("ee9038a2-9359-4d5c-b637-7e50dcf4c193"), 69.0, 17.600000000000001, 0.20000000000000001, 8.0, "Виноград", 0.59999999999999998, 10.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("03b522b9-210a-4faf-a9b7-7a361b754e6b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("17c60770-bf83-4352-a02d-5b5d264a8478"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("2a39268e-f031-4656-b2ca-27d5c71d91bb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("3d034664-4d20-47ff-894b-6f8b418ddcef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("47882663-9b1f-47c8-9fdc-746cf211332c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("528658b5-5540-4e2d-9fa2-bfc7a179be1c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("54592414-12ad-415a-9b43-1c494968270d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("64fa9ecb-7921-4ca7-9553-0bf9c067c382"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("728e88f6-cc6f-4c6c-8596-2aa7ec1cf101"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("ae1ffb60-b121-4bc2-bf23-05aaa2776bc5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("b9dff157-9b81-45c7-a3ec-86b8de4670b1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("cce45639-8723-499e-8c81-ba8485ee590b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("e79b935e-6874-497a-af63-40cd590e67ca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("fdd8d62c-62fc-45ab-8aa5-8dffc880b98d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("00cc3f3f-922f-497e-a6f0-fa2104bc1df5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("186d4b86-711f-4931-985c-d465cf060598"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("259b3583-ffb0-4820-a794-b2119d2f0777"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("26e13a47-b669-4e0c-99af-c10528120f52"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("4ab9ffca-c8e7-43b1-8678-7753ceab2918"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("742a9f79-1a21-4ea9-ac8b-e99cc63cc0f0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("b350504a-19c4-46ad-8cf2-a817eb86ccc8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("d3552b31-058c-45a2-95e1-1233f392c84a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("de7c1324-4917-440a-92b3-baa240fed066"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("ee9038a2-9359-4d5c-b637-7e50dcf4c193"));

            migrationBuilder.AddColumn<double>(
                name: "TrashPercentage",
                table: "Consumptions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TrashWeight",
                table: "Consumptions",
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
    }
}
