using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodLog.DAL.Migrations
{
    /// <inheritdoc />
    public partial class _111 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("0397e67e-3c45-4988-bb85-525a41b5550a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("2328134f-aa0c-487d-b502-500ec7b7e025"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("238160c8-f82c-4286-a48b-67512b7a74ef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("2b83bcc0-9288-4bff-b55b-e06ec407d748"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("3f3c5087-e685-46d4-a139-c12f39f49371"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("4c92de82-09af-477e-a808-a2ad93a4d0b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("5578237b-f421-4ac5-8d25-ab3522b4126f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("5a0882ea-1cef-4108-84d5-74d62a13b1a1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("62d92b20-23ac-4f28-a0be-bab07697f307"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("757d103a-b63b-4a26-bce1-1670c760533b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("a3265c76-adc4-41a9-a7fa-61f5b1b4298c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("a85b44c7-428b-497b-9a96-c5059e2eaaac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("b4d90c1c-8fb7-492d-b3a3-0be8348b14f8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("b6f9759c-bad8-4c8e-a8f2-41e0f6efccca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("0a6034e2-5b5f-4ae1-9eba-5f617c85cbcf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("0b5add46-6d22-4a57-a788-4b55cdba8613"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("1c3af32a-7fbd-4c43-b12b-3485d833c06a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("35aeafb1-cacd-4ea0-a103-f46f3ee20c38"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("50c105ec-c66a-4e59-8e6b-55c2b5b1734e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("55b7ea05-878f-4554-b6b6-ea507a6e2832"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("894a9ab0-060c-4a1c-a199-31d25d77fa6f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("bfca28fb-42d1-4c35-9c96-f47f80ff10be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("e7507c04-5fbf-4792-bbee-d2ee535ea143"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("ec8f5e18-0d69-4372-aaf1-272a932cd798"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("08f807ee-d375-4ec9-9cd7-b4ddabebf02f"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("564666a4-9990-46f0-bd75-636448c36760"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("cc7325f8-47de-4603-bcba-22de71faccc2"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("e40ab665-6390-4642-b989-fee2a5593808"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Guid", "Name" },
                values: new object[,]
                {
                    { new Guid("0397e67e-3c45-4988-bb85-525a41b5550a"), "Соки / Чай" },
                    { new Guid("2328134f-aa0c-487d-b502-500ec7b7e025"), "Молочка" },
                    { new Guid("238160c8-f82c-4286-a48b-67512b7a74ef"), "Мясо" },
                    { new Guid("2b83bcc0-9288-4bff-b55b-e06ec407d748"), "Вода" },
                    { new Guid("3f3c5087-e685-46d4-a139-c12f39f49371"), "Термичка растительная" },
                    { new Guid("4c92de82-09af-477e-a808-a2ad93a4d0b4"), "Рыба / Морепродукты" },
                    { new Guid("5578237b-f421-4ac5-8d25-ab3522b4126f"), "Термичка на ПЖП" },
                    { new Guid("5a0882ea-1cef-4108-84d5-74d62a13b1a1"), "Орехи / Злаки / Семена" },
                    { new Guid("62d92b20-23ac-4f28-a0be-bab07697f307"), "Кофе" },
                    { new Guid("757d103a-b63b-4a26-bce1-1670c760533b"), "Зелень / Овощи" },
                    { new Guid("a3265c76-adc4-41a9-a7fa-61f5b1b4298c"), "Сухофрукты" },
                    { new Guid("a85b44c7-428b-497b-9a96-c5059e2eaaac"), "Фрукты" },
                    { new Guid("b4d90c1c-8fb7-492d-b3a3-0be8348b14f8"), "Яйцо" },
                    { new Guid("b6f9759c-bad8-4c8e-a8f2-41e0f6efccca"), "Кондитерка" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Guid", "Caloriers", "Carb", "Fat", "HarmScore", "Name", "Prot", "TrashPercentage" },
                values: new object[,]
                {
                    { new Guid("0a6034e2-5b5f-4ae1-9eba-5f617c85cbcf"), 61.0, 14.6, 0.5, 6.0, "Киви", 1.1000000000000001, 12.0 },
                    { new Guid("0b5add46-6d22-4a57-a788-4b55cdba8613"), 69.0, 17.600000000000001, 0.20000000000000001, 8.0, "Виноград", 0.59999999999999998, 10.0 },
                    { new Guid("1c3af32a-7fbd-4c43-b12b-3485d833c06a"), 576.0, 6.0, 49.0, 20.0, "Миндаль", 21.0, 0.0 },
                    { new Guid("35aeafb1-cacd-4ea0-a103-f46f3ee20c38"), 59.0, 4.7000000000000002, 3.0, 15.0, "Йогурт", 3.5, 0.0 },
                    { new Guid("50c105ec-c66a-4e59-8e6b-55c2b5b1734e"), 96.0, 21.0, 0.20000000000000001, 10.0, "Банан", 1.0, 36.0 },
                    { new Guid("55b7ea05-878f-4554-b6b6-ea507a6e2832"), 18.0, 3.8999999999999999, 0.20000000000000001, 5.0, "Томат", 0.90000000000000002, 5.0 },
                    { new Guid("894a9ab0-060c-4a1c-a199-31d25d77fa6f"), 208.0, 0.0, 14.300000000000001, 25.0, "Лосось", 20.0, 0.0 },
                    { new Guid("bfca28fb-42d1-4c35-9c96-f47f80ff10be"), 57.0, 12.699999999999999, 0.10000000000000001, 7.0, "Груша", 0.40000000000000002, 3.0 },
                    { new Guid("e7507c04-5fbf-4792-bbee-d2ee535ea143"), 43.0, 8.1999999999999993, 0.20000000000000001, 5.0, "Апельсин", 0.90000000000000002, 40.0 },
                    { new Guid("ec8f5e18-0d69-4372-aaf1-272a932cd798"), 52.0, 11.4, 0.40000000000000002, 10.0, "Яблоко", 0.29999999999999999, 10.0 }
                });

            migrationBuilder.InsertData(
                table: "WriteOffReasons",
                columns: new[] { "Guid", "ReasonName" },
                values: new object[,]
                {
                    { new Guid("08f807ee-d375-4ec9-9cd7-b4ddabebf02f"), "Испортился" },
                    { new Guid("564666a4-9990-46f0-bd75-636448c36760"), "Несъедобная часть" },
                    { new Guid("cc7325f8-47de-4603-bcba-22de71faccc2"), "Потеря/усушка" },
                    { new Guid("e40ab665-6390-4642-b989-fee2a5593808"), "Угостил" }
                });
        }
    }
}
