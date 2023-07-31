using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodLog.DAL.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("015699e6-c0ca-48e9-a33d-bd435cc48f32"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("2a0b9767-54af-4d30-b78b-076f906ff219"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("2b1bf6e2-a102-405f-a71c-f6e43247f3e3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("4a99730b-b1be-421b-8f92-59ccbda7bd7a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("65201f0b-4cd0-4b10-9adc-f522497fa4a3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("71507063-96d5-4d46-95f7-148616d311fa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("80a5cdb7-027f-41eb-beb1-b3cce15bce7d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("81d26703-b1ab-4653-a349-c3f6966ceb67"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("8c60df7b-5622-403e-a8df-2d1807ea6f8b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("b1df4bed-4da1-43f7-a239-8429df486f31"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("b1f676c2-3c51-4f95-9c52-6f3e9bbb1d39"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("bae62cc2-09dd-4378-a3b7-db17553f561b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("c2ca7a71-b405-41bc-aa2b-7669770f4d45"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("c9786ff6-730d-416a-8451-24e1ccee3672"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("36e1e24f-0d3a-4e49-947a-7f626e9e35c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("8a96de66-2a21-4f73-9dc6-9fde412dd8bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("add1a58e-09f1-4b0e-98c6-5c505b03b442"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("d01b5c93-417c-4a04-8892-912acf867311"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("d279b6f8-6ebf-4731-a07d-a47f9f8edf20"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("d8cfdd60-e116-4d05-9b34-cf58f4401e77"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("de7e8d38-21ea-4c2b-86a9-b392cd8cfc85"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("df36a914-bcd3-4570-b122-eda98f4a54fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("e329670d-c2fd-41a0-90f5-5a7714205ade"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("f22d0509-f036-4eaf-9510-32b86c724b60"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("20c0bf6b-83a4-4610-950a-2ec28ebde306"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("2af7f174-1427-4658-a110-4c5e06302987"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("6f09b3da-5c1b-4a21-b0d8-b332d0e611c3"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("9ca999be-129f-4e6c-bb7a-ccb8bc8acef8"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("015699e6-c0ca-48e9-a33d-bd435cc48f32"), "Зелень / Овощи" },
                    { new Guid("2a0b9767-54af-4d30-b78b-076f906ff219"), "Молочка" },
                    { new Guid("2b1bf6e2-a102-405f-a71c-f6e43247f3e3"), "Соки / Чай" },
                    { new Guid("4a99730b-b1be-421b-8f92-59ccbda7bd7a"), "Кондитерка" },
                    { new Guid("65201f0b-4cd0-4b10-9adc-f522497fa4a3"), "Яйцо" },
                    { new Guid("71507063-96d5-4d46-95f7-148616d311fa"), "Фрукты" },
                    { new Guid("80a5cdb7-027f-41eb-beb1-b3cce15bce7d"), "Орехи / Злаки / Семена" },
                    { new Guid("81d26703-b1ab-4653-a349-c3f6966ceb67"), "Кофе" },
                    { new Guid("8c60df7b-5622-403e-a8df-2d1807ea6f8b"), "Мясо" },
                    { new Guid("b1df4bed-4da1-43f7-a239-8429df486f31"), "Вода" },
                    { new Guid("b1f676c2-3c51-4f95-9c52-6f3e9bbb1d39"), "Термичка растительная" },
                    { new Guid("bae62cc2-09dd-4378-a3b7-db17553f561b"), "Рыба / Морепродукты" },
                    { new Guid("c2ca7a71-b405-41bc-aa2b-7669770f4d45"), "Сухофрукты" },
                    { new Guid("c9786ff6-730d-416a-8451-24e1ccee3672"), "Термичка на ПЖП" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Guid", "Caloriers", "Carb", "Fat", "HarmScore", "Name", "Prot", "TrashPercentage" },
                values: new object[,]
                {
                    { new Guid("36e1e24f-0d3a-4e49-947a-7f626e9e35c3"), 52.0, 11.4, 0.40000000000000002, 10.0, "Яблоко", 0.29999999999999999, 10.0 },
                    { new Guid("8a96de66-2a21-4f73-9dc6-9fde412dd8bd"), 96.0, 21.0, 0.20000000000000001, 10.0, "Банан", 1.0, 36.0 },
                    { new Guid("add1a58e-09f1-4b0e-98c6-5c505b03b442"), 59.0, 4.7000000000000002, 3.0, 15.0, "Йогурт", 3.5, 0.0 },
                    { new Guid("d01b5c93-417c-4a04-8892-912acf867311"), 18.0, 3.8999999999999999, 0.20000000000000001, 5.0, "Томат", 0.90000000000000002, 5.0 },
                    { new Guid("d279b6f8-6ebf-4731-a07d-a47f9f8edf20"), 61.0, 14.6, 0.5, 6.0, "Киви", 1.1000000000000001, 12.0 },
                    { new Guid("d8cfdd60-e116-4d05-9b34-cf58f4401e77"), 576.0, 6.0, 49.0, 20.0, "Миндаль", 21.0, 0.0 },
                    { new Guid("de7e8d38-21ea-4c2b-86a9-b392cd8cfc85"), 208.0, 0.0, 14.300000000000001, 25.0, "Лосось", 20.0, 0.0 },
                    { new Guid("df36a914-bcd3-4570-b122-eda98f4a54fd"), 69.0, 17.600000000000001, 0.20000000000000001, 8.0, "Виноград", 0.59999999999999998, 10.0 },
                    { new Guid("e329670d-c2fd-41a0-90f5-5a7714205ade"), 57.0, 12.699999999999999, 0.10000000000000001, 7.0, "Груша", 0.40000000000000002, 3.0 },
                    { new Guid("f22d0509-f036-4eaf-9510-32b86c724b60"), 43.0, 8.1999999999999993, 0.20000000000000001, 5.0, "Апельсин", 0.90000000000000002, 40.0 }
                });

            migrationBuilder.InsertData(
                table: "WriteOffReasons",
                columns: new[] { "Guid", "ReasonName" },
                values: new object[,]
                {
                    { new Guid("20c0bf6b-83a4-4610-950a-2ec28ebde306"), "Несъедобная часть" },
                    { new Guid("2af7f174-1427-4658-a110-4c5e06302987"), "Испортился" },
                    { new Guid("6f09b3da-5c1b-4a21-b0d8-b332d0e611c3"), "Потеря/усушка" },
                    { new Guid("9ca999be-129f-4e6c-bb7a-ccb8bc8acef8"), "Угостил" }
                });
        }
    }
}
