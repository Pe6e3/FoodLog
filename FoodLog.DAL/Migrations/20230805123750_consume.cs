using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodLog.DAL.Migrations
{
    /// <inheritdoc />
    public partial class consume : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("0f909ffa-94b8-4b1c-9aa8-7b11af56ad8c"), "Яйцо" },
                    { new Guid("17341319-ffca-4597-9820-78427d90901e"), "Зелень / Овощи" },
                    { new Guid("22c9fdb0-405a-4980-827d-bcbd0bcfc24a"), "Рыба / Морепродукты" },
                    { new Guid("5dac8a43-312d-4ff0-a2b1-f8e89e18c724"), "Молочка" },
                    { new Guid("6b108568-7492-4808-a335-ec5374673d68"), "Вода" },
                    { new Guid("8942e60e-5463-47a3-b2ff-7107e63fd176"), "Орехи / Злаки / Семена" },
                    { new Guid("b078ee2c-9755-4104-b207-ca8b0ffebc5b"), "Кофе" },
                    { new Guid("b1758d9a-7b62-4554-bf4d-a0745d48a31f"), "Термичка на ПЖП" },
                    { new Guid("b4e5a9d6-890a-4994-a7ad-544fc30547e7"), "Сухофрукты" },
                    { new Guid("cfac30be-aab0-423e-8b21-577009651e54"), "Термичка растительная" },
                    { new Guid("d948f478-6727-4b50-8cd1-6a74accc12ad"), "Фрукты" },
                    { new Guid("e12db112-0b4f-49ca-8ca5-5be812f29e41"), "Мясо" },
                    { new Guid("e975bdc5-2259-4c2b-a2ea-fe338245dc95"), "Кондитерка" },
                    { new Guid("f53399f7-b87d-4e76-9dc6-35bcea68a5d0"), "Соки / Чай" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Guid", "Calories", "Carb", "Fat", "HarmScore", "Name", "Prot", "TrashPercentage" },
                values: new object[,]
                {
                    { new Guid("04cbbc23-bf00-4fbb-bc52-000b6cda1c23"), 18.0, 3.8999999999999999, 0.20000000000000001, 5.0, "Томат", 0.90000000000000002, 5.0 },
                    { new Guid("0d7acc9a-695f-430a-8e7d-d2f2db4a9345"), 59.0, 4.7000000000000002, 3.0, 15.0, "Йогурт", 3.5, 0.0 },
                    { new Guid("171cdd2c-02f4-4abe-8a33-1f7a7eded799"), 576.0, 6.0, 49.0, 20.0, "Миндаль", 21.0, 0.0 },
                    { new Guid("1cc91186-3e14-4ada-ba41-5ac9ead75cb5"), 43.0, 8.1999999999999993, 0.20000000000000001, 5.0, "Апельсин", 0.90000000000000002, 40.0 },
                    { new Guid("1d3d5a7e-4e18-42a4-8741-d34f9196525d"), 69.0, 17.600000000000001, 0.20000000000000001, 8.0, "Виноград", 0.59999999999999998, 10.0 },
                    { new Guid("58bc0865-e883-4c60-bf47-1f822d2acb8e"), 52.0, 11.4, 0.40000000000000002, 10.0, "Яблоко", 0.29999999999999999, 10.0 },
                    { new Guid("5ca7b70f-5841-4889-b5d5-1c25a875f7cc"), 96.0, 21.0, 0.20000000000000001, 10.0, "Банан", 1.0, 36.0 },
                    { new Guid("5cd1c23b-7c95-41cd-af32-12d41190ff14"), 61.0, 14.6, 0.5, 6.0, "Киви", 1.1000000000000001, 12.0 },
                    { new Guid("6c536930-3e1e-46f8-adb5-dae229832155"), 57.0, 12.699999999999999, 0.10000000000000001, 7.0, "Груша", 0.40000000000000002, 3.0 },
                    { new Guid("a799e640-5ad3-4dee-896c-8f98384156fa"), 208.0, 0.0, 14.300000000000001, 25.0, "Лосось", 20.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "WriteOffReasons",
                columns: new[] { "Guid", "ReasonName" },
                values: new object[,]
                {
                    { new Guid("3c1b888e-cde8-45e4-b494-ae2d66b3f840"), "Испортился" },
                    { new Guid("a061bedc-81c4-4a29-8ed5-f428a391a57a"), "Угостил" },
                    { new Guid("b4f4d12c-358d-493e-a4a9-ec3eb3645a9f"), "Несъедобная часть" },
                    { new Guid("cbc06795-b9b5-4cdd-bac2-9b603cd77723"), "Потеря/усушка" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("0f909ffa-94b8-4b1c-9aa8-7b11af56ad8c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("17341319-ffca-4597-9820-78427d90901e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("22c9fdb0-405a-4980-827d-bcbd0bcfc24a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("5dac8a43-312d-4ff0-a2b1-f8e89e18c724"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("6b108568-7492-4808-a335-ec5374673d68"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("8942e60e-5463-47a3-b2ff-7107e63fd176"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("b078ee2c-9755-4104-b207-ca8b0ffebc5b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("b1758d9a-7b62-4554-bf4d-a0745d48a31f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("b4e5a9d6-890a-4994-a7ad-544fc30547e7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("cfac30be-aab0-423e-8b21-577009651e54"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("d948f478-6727-4b50-8cd1-6a74accc12ad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("e12db112-0b4f-49ca-8ca5-5be812f29e41"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("e975bdc5-2259-4c2b-a2ea-fe338245dc95"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("f53399f7-b87d-4e76-9dc6-35bcea68a5d0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("04cbbc23-bf00-4fbb-bc52-000b6cda1c23"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("0d7acc9a-695f-430a-8e7d-d2f2db4a9345"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("171cdd2c-02f4-4abe-8a33-1f7a7eded799"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("1cc91186-3e14-4ada-ba41-5ac9ead75cb5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("1d3d5a7e-4e18-42a4-8741-d34f9196525d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("58bc0865-e883-4c60-bf47-1f822d2acb8e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("5ca7b70f-5841-4889-b5d5-1c25a875f7cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("5cd1c23b-7c95-41cd-af32-12d41190ff14"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("6c536930-3e1e-46f8-adb5-dae229832155"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("a799e640-5ad3-4dee-896c-8f98384156fa"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("3c1b888e-cde8-45e4-b494-ae2d66b3f840"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("a061bedc-81c4-4a29-8ed5-f428a391a57a"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("b4f4d12c-358d-493e-a4a9-ec3eb3645a9f"));

            migrationBuilder.DeleteData(
                table: "WriteOffReasons",
                keyColumn: "Guid",
                keyValue: new Guid("cbc06795-b9b5-4cdd-bac2-9b603cd77723"));

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
        }
    }
}
