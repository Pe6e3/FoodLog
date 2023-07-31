using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodLog.DAL.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trashes_WriteOffReason_WriteOffReasonGuid",
                table: "Trashes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WriteOffReason",
                table: "WriteOffReason");

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

            migrationBuilder.RenameTable(
                name: "WriteOffReason",
                newName: "WriteOffReasons");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WriteOffReasons",
                table: "WriteOffReasons",
                column: "Guid");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Trashes_WriteOffReasons_WriteOffReasonGuid",
                table: "Trashes",
                column: "WriteOffReasonGuid",
                principalTable: "WriteOffReasons",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trashes_WriteOffReasons_WriteOffReasonGuid",
                table: "Trashes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WriteOffReasons",
                table: "WriteOffReasons");

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

            migrationBuilder.RenameTable(
                name: "WriteOffReasons",
                newName: "WriteOffReason");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WriteOffReason",
                table: "WriteOffReason",
                column: "Guid");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Trashes_WriteOffReason_WriteOffReasonGuid",
                table: "Trashes",
                column: "WriteOffReasonGuid",
                principalTable: "WriteOffReason",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
