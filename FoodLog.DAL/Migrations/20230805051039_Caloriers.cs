using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodLog.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Caloriers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumptions_Purchases_PurchaseGuid",
                table: "Consumptions");

            migrationBuilder.DropIndex(
                name: "IX_Consumptions_PurchaseGuid",
                table: "Consumptions");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("09bfc9a6-cdd5-466f-89e0-f1dcf5b78d14"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("26fd5306-bf0b-43d4-ba44-4cdd9b2656f4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("27220565-ed98-4539-a058-ab3052a87a10"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("3acae9b6-8506-4a9c-bd32-34db36702df4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("44278d56-c9f4-497f-a70c-45dd40fea258"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("4a027cbc-3002-4314-b163-8d0b8fed8b3c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("7a53d1d2-c51f-4f96-a1bd-0d152a8a23a8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("7c46c288-9dab-4ab8-a844-6ae9f994f679"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("965ed878-64e9-4ce2-a193-e2fce9dd57be"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("9bc89530-48a3-4a29-ac22-899ac95deee5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("9d42513a-2dd6-4cc5-8bc6-8c8b92d58e4a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("a9e27af0-b138-4ad3-a690-1b73e3c05e8b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("b8d52205-7775-4478-9aac-95249b4078cb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("cefd207a-2189-4511-b561-860c4432a7ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("0628b102-16cc-4faa-b688-21cd5d8c2332"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("34511e28-683e-4740-8b87-0396c74f246b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("37b75af3-8cfa-4933-aa33-a5b279128c20"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("4660dc27-419c-4923-afa8-435632dff217"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("49d83145-4fca-4816-b785-446734a6372d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("58809d41-a01d-4795-81ad-1148caab64aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("b66dcaf8-0634-40f9-99ac-d19022cad85e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("c0d37cca-514c-419a-aefa-8004ea6f7490"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("d3dc68aa-9d55-4c88-a291-57623a8b4638"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("db33e6e2-fc02-4247-8fd2-574960fd6165"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("2944c545-ce79-4fc4-a92b-300747d0bf94"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("41abc6f0-d046-4995-8b16-65905e4de9dc"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("8ad473da-1b07-4aba-8c29-a7a572096c2d"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("c7f208bf-5b51-4d95-8c0f-39b526d91ff4"));

            migrationBuilder.DropColumn(
                name: "PurchaseGuid",
                table: "Consumptions");

            migrationBuilder.RenameColumn(
                name: "Caloriers",
                table: "Products",
                newName: "Calories");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Guid", "Name" },
                values: new object[,]
                {
                    { new Guid("04db650f-32b2-4122-afed-380bf163a7d6"), "Соки / Чай" },
                    { new Guid("05ac6f0d-49c0-4da6-bcc9-70279bc75945"), "Зелень / Овощи" },
                    { new Guid("14093f81-7c55-4cc1-9d7a-bfd919a4c1dd"), "Кофе" },
                    { new Guid("2cbc2e18-60f5-429b-a2cc-e1f06f86f40e"), "Мясо" },
                    { new Guid("410922fd-bd83-4f83-9179-2a69cb8a7268"), "Яйцо" },
                    { new Guid("780c361c-6848-4462-8d0f-3e95d6678e05"), "Термичка растительная" },
                    { new Guid("94c7e179-0417-4688-9d24-16687edf1888"), "Вода" },
                    { new Guid("c8a49754-7ed0-4369-bd00-12253a453e3b"), "Молочка" },
                    { new Guid("d92dbf34-0fe8-4cad-b983-b64d21a90346"), "Рыба / Морепродукты" },
                    { new Guid("e3cddc1a-ad78-4d81-90f1-15347a66b6e4"), "Термичка на ПЖП" },
                    { new Guid("e4f34929-3bdc-4368-9bbe-e283ece1f771"), "Орехи / Злаки / Семена" },
                    { new Guid("e5e22abc-9a6e-40ca-85f0-98d0afce9cdf"), "Кондитерка" },
                    { new Guid("f38e37a9-25f8-4cf4-a590-fdbce5c142bf"), "Сухофрукты" },
                    { new Guid("f4872169-dff2-4bc8-9a66-124b8c7b40dd"), "Фрукты" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Guid", "Calories", "Carb", "Fat", "HarmScore", "Name", "Prot", "TrashPercentage" },
                values: new object[,]
                {
                    { new Guid("03107ddc-06cb-442c-9101-90b9101d7842"), 59.0, 4.7000000000000002, 3.0, 15.0, "Йогурт", 3.5, 0.0 },
                    { new Guid("29a9279b-315c-4563-8262-336c7701b515"), 52.0, 11.4, 0.40000000000000002, 10.0, "Яблоко", 0.29999999999999999, 10.0 },
                    { new Guid("2db2dede-0ece-4836-87da-ab5dc8b144df"), 43.0, 8.1999999999999993, 0.20000000000000001, 5.0, "Апельсин", 0.90000000000000002, 40.0 },
                    { new Guid("7a385085-172b-4c0a-8926-38d8bbca5bc5"), 96.0, 21.0, 0.20000000000000001, 10.0, "Банан", 1.0, 36.0 },
                    { new Guid("8f8d5d01-57fc-4c49-aa8d-5acd1e430671"), 576.0, 6.0, 49.0, 20.0, "Миндаль", 21.0, 0.0 },
                    { new Guid("97a1bc28-f986-4244-b6b5-2da74c59a4af"), 69.0, 17.600000000000001, 0.20000000000000001, 8.0, "Виноград", 0.59999999999999998, 10.0 },
                    { new Guid("ab819ab4-b5d4-4579-a982-18ee7eece55a"), 208.0, 0.0, 14.300000000000001, 25.0, "Лосось", 20.0, 0.0 },
                    { new Guid("b04c9e3d-61c7-499d-8caa-e213c69b7d1d"), 57.0, 12.699999999999999, 0.10000000000000001, 7.0, "Груша", 0.40000000000000002, 3.0 },
                    { new Guid("b7513f00-1875-49ba-9328-015e969e483b"), 18.0, 3.8999999999999999, 0.20000000000000001, 5.0, "Томат", 0.90000000000000002, 5.0 },
                    { new Guid("cef8f85f-eab9-4b65-af8c-7c569070f1bf"), 61.0, 14.6, 0.5, 6.0, "Киви", 1.1000000000000001, 12.0 }
                });

            migrationBuilder.InsertData(
                table: "WriteOffReasons",
                columns: new[] { "Guid", "ReasonName" },
                values: new object[,]
                {
                    { new Guid("1576a860-91c4-48f2-9c8b-9ea7a8eca4ae"), "Испортился" },
                    { new Guid("7009375a-550a-4c97-a4db-8db065bfa444"), "Угостил" },
                    { new Guid("e2b1b26f-cf85-4fc4-9152-03d36673ae2b"), "Несъедобная часть" },
                    { new Guid("f1375eae-9b79-4d28-be1b-733acfe070dd"), "Потеря/усушка" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consumptions_GuidOfPurchase",
                table: "Consumptions",
                column: "GuidOfPurchase");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumptions_Purchases_GuidOfPurchase",
                table: "Consumptions",
                column: "GuidOfPurchase",
                principalTable: "Purchases",
                principalColumn: "Guid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumptions_Purchases_GuidOfPurchase",
                table: "Consumptions");

            migrationBuilder.DropIndex(
                name: "IX_Consumptions_GuidOfPurchase",
                table: "Consumptions");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("04db650f-32b2-4122-afed-380bf163a7d6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("05ac6f0d-49c0-4da6-bcc9-70279bc75945"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("14093f81-7c55-4cc1-9d7a-bfd919a4c1dd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("2cbc2e18-60f5-429b-a2cc-e1f06f86f40e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("410922fd-bd83-4f83-9179-2a69cb8a7268"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("780c361c-6848-4462-8d0f-3e95d6678e05"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("94c7e179-0417-4688-9d24-16687edf1888"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("c8a49754-7ed0-4369-bd00-12253a453e3b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("d92dbf34-0fe8-4cad-b983-b64d21a90346"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("e3cddc1a-ad78-4d81-90f1-15347a66b6e4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("e4f34929-3bdc-4368-9bbe-e283ece1f771"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("e5e22abc-9a6e-40ca-85f0-98d0afce9cdf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("f38e37a9-25f8-4cf4-a590-fdbce5c142bf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("f4872169-dff2-4bc8-9a66-124b8c7b40dd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("03107ddc-06cb-442c-9101-90b9101d7842"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("29a9279b-315c-4563-8262-336c7701b515"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("2db2dede-0ece-4836-87da-ab5dc8b144df"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("7a385085-172b-4c0a-8926-38d8bbca5bc5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("8f8d5d01-57fc-4c49-aa8d-5acd1e430671"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("97a1bc28-f986-4244-b6b5-2da74c59a4af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("ab819ab4-b5d4-4579-a982-18ee7eece55a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("b04c9e3d-61c7-499d-8caa-e213c69b7d1d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("b7513f00-1875-49ba-9328-015e969e483b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("cef8f85f-eab9-4b65-af8c-7c569070f1bf"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("1576a860-91c4-48f2-9c8b-9ea7a8eca4ae"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("7009375a-550a-4c97-a4db-8db065bfa444"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("e2b1b26f-cf85-4fc4-9152-03d36673ae2b"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("f1375eae-9b79-4d28-be1b-733acfe070dd"));

            migrationBuilder.RenameColumn(
                name: "Calories",
                table: "Products",
                newName: "Caloriers");

            migrationBuilder.AddColumn<Guid>(
                name: "PurchaseGuid",
                table: "Consumptions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Guid", "Name" },
                values: new object[,]
                {
                    { new Guid("09bfc9a6-cdd5-466f-89e0-f1dcf5b78d14"), "Яйцо" },
                    { new Guid("26fd5306-bf0b-43d4-ba44-4cdd9b2656f4"), "Фрукты" },
                    { new Guid("27220565-ed98-4539-a058-ab3052a87a10"), "Кондитерка" },
                    { new Guid("3acae9b6-8506-4a9c-bd32-34db36702df4"), "Сухофрукты" },
                    { new Guid("44278d56-c9f4-497f-a70c-45dd40fea258"), "Орехи / Злаки / Семена" },
                    { new Guid("4a027cbc-3002-4314-b163-8d0b8fed8b3c"), "Рыба / Морепродукты" },
                    { new Guid("7a53d1d2-c51f-4f96-a1bd-0d152a8a23a8"), "Термичка на ПЖП" },
                    { new Guid("7c46c288-9dab-4ab8-a844-6ae9f994f679"), "Молочка" },
                    { new Guid("965ed878-64e9-4ce2-a193-e2fce9dd57be"), "Зелень / Овощи" },
                    { new Guid("9bc89530-48a3-4a29-ac22-899ac95deee5"), "Кофе" },
                    { new Guid("9d42513a-2dd6-4cc5-8bc6-8c8b92d58e4a"), "Термичка растительная" },
                    { new Guid("a9e27af0-b138-4ad3-a690-1b73e3c05e8b"), "Вода" },
                    { new Guid("b8d52205-7775-4478-9aac-95249b4078cb"), "Соки / Чай" },
                    { new Guid("cefd207a-2189-4511-b561-860c4432a7ac"), "Мясо" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Guid", "Caloriers", "Carb", "Fat", "HarmScore", "Name", "Prot", "TrashPercentage" },
                values: new object[,]
                {
                    { new Guid("0628b102-16cc-4faa-b688-21cd5d8c2332"), 59.0, 4.7000000000000002, 3.0, 15.0, "Йогурт", 3.5, 0.0 },
                    { new Guid("34511e28-683e-4740-8b87-0396c74f246b"), 576.0, 6.0, 49.0, 20.0, "Миндаль", 21.0, 0.0 },
                    { new Guid("37b75af3-8cfa-4933-aa33-a5b279128c20"), 69.0, 17.600000000000001, 0.20000000000000001, 8.0, "Виноград", 0.59999999999999998, 10.0 },
                    { new Guid("4660dc27-419c-4923-afa8-435632dff217"), 96.0, 21.0, 0.20000000000000001, 10.0, "Банан", 1.0, 36.0 },
                    { new Guid("49d83145-4fca-4816-b785-446734a6372d"), 52.0, 11.4, 0.40000000000000002, 10.0, "Яблоко", 0.29999999999999999, 10.0 },
                    { new Guid("58809d41-a01d-4795-81ad-1148caab64aa"), 208.0, 0.0, 14.300000000000001, 25.0, "Лосось", 20.0, 0.0 },
                    { new Guid("b66dcaf8-0634-40f9-99ac-d19022cad85e"), 61.0, 14.6, 0.5, 6.0, "Киви", 1.1000000000000001, 12.0 },
                    { new Guid("c0d37cca-514c-419a-aefa-8004ea6f7490"), 57.0, 12.699999999999999, 0.10000000000000001, 7.0, "Груша", 0.40000000000000002, 3.0 },
                    { new Guid("d3dc68aa-9d55-4c88-a291-57623a8b4638"), 43.0, 8.1999999999999993, 0.20000000000000001, 5.0, "Апельсин", 0.90000000000000002, 40.0 },
                    { new Guid("db33e6e2-fc02-4247-8fd2-574960fd6165"), 18.0, 3.8999999999999999, 0.20000000000000001, 5.0, "Томат", 0.90000000000000002, 5.0 }
                });

            migrationBuilder.InsertData(
                table: "WriteOffReasons",
                columns: new[] { "Guid", "ReasonName" },
                values: new object[,]
                {
                    { new Guid("2944c545-ce79-4fc4-a92b-300747d0bf94"), "Испортился" },
                    { new Guid("41abc6f0-d046-4995-8b16-65905e4de9dc"), "Угостил" },
                    { new Guid("8ad473da-1b07-4aba-8c29-a7a572096c2d"), "Несъедобная часть" },
                    { new Guid("c7f208bf-5b51-4d95-8c0f-39b526d91ff4"), "Потеря/усушка" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consumptions_PurchaseGuid",
                table: "Consumptions",
                column: "PurchaseGuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumptions_Purchases_PurchaseGuid",
                table: "Consumptions",
                column: "PurchaseGuid",
                principalTable: "Purchases",
                principalColumn: "Guid");
        }
    }
}
