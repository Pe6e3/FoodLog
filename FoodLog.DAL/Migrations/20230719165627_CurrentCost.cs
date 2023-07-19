using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodLog.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CurrentCost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("0400f00c-5de8-4982-9dcf-bf63011eaa67"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("0956d6f2-f6b5-4f98-8e35-6c1389016f29"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("16792ee2-412a-412e-8922-8a1c76fff717"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("24252d96-1df6-4c52-ac0f-a8ea49c2889d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("41105352-c33a-4ee4-bd7a-fc775612b4d1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("55bcb14f-4ee1-48f1-a0db-b5c1e7af558c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("58cc1a90-2eae-4cf7-8ccf-de076c7549fc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("7a687d39-ecae-4534-bc68-44e357afd8dc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("857e1f0c-d056-43e6-8f13-d2ad054258b8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("a31d0f03-53fe-4e31-ae1a-d8b624b84eea"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("a8388dac-c6a9-4d8d-a42f-edade76fbfbd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("ac3d2dbd-fde7-41cc-b24e-d66f3b15a692"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("fa0b03e7-251f-4d06-909a-bf970ab4c9e1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("fb3a1a4c-6c3c-4bd1-923d-fa99a76a52fc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("284278bc-72f8-4319-9bef-e21021b91fe4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("2bf65814-578e-4cc4-9d75-50c70e7a6ca5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("53f8d448-0aca-4275-b49f-cce130d49908"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("60a6146f-225e-4423-aef0-9ad1641273af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("7a1fd7b7-734d-4913-8530-132729f7f931"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("a443e2e3-a7c6-4519-a713-cc0813445964"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("aec3a178-0855-45d3-8a93-005cdff59dac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("ccbca229-f939-48f3-a45f-dda3dfc598bf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("f315d9b9-de01-4ade-aca5-35bc481bdf45"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("f3fcf9c8-ee1a-493a-ab75-5a2003e3817a"));

            migrationBuilder.AddColumn<double>(
                name: "CurrentCost",
                table: "StorageProducts",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Guid", "Name" },
                values: new object[,]
                {
                    { new Guid("0b180204-52e5-4d52-a632-785a0ae884e9"), "Орехи / Злаки / Семена" },
                    { new Guid("0e2c2afc-c1ee-4fb3-be6a-be57fd1769e4"), "Кондитерка" },
                    { new Guid("185de742-b463-4710-a23d-22c0bc0387e9"), "Рыба / Морепродукты" },
                    { new Guid("2078c0a3-7ab6-47c2-a2d8-f478ff1e6e17"), "Молочка" },
                    { new Guid("3726bd39-beb7-44ab-91ca-a4c5de60c391"), "Термичка на ПЖП" },
                    { new Guid("48dabd4f-8da8-467b-a5be-b71928d22521"), "Фрукты" },
                    { new Guid("5c62a052-82f9-45b1-9892-edf56fdaa043"), "Мясо" },
                    { new Guid("6efb5723-1a3d-4776-b6fb-b34c19cdb852"), "Сухофрукты" },
                    { new Guid("7345f12f-d3ed-40ef-8167-97779018ab3a"), "Вода" },
                    { new Guid("78117f12-9285-489c-9386-08e35ada6579"), "Кофе" },
                    { new Guid("911cdf9f-ab03-4aea-82cb-0ad383fa02da"), "Зелень / Овощи" },
                    { new Guid("b3d49557-8bfd-43b3-af46-b98025207676"), "Яйцо" },
                    { new Guid("bee578de-d984-4228-b4e4-3891fae1a38e"), "Соки / Чай" },
                    { new Guid("c87ac475-2386-458f-93c3-82b20fddf048"), "Термичка растительная" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Guid", "Caloriers", "Carb", "Fat", "HarmScore", "Name", "Prot" },
                values: new object[,]
                {
                    { new Guid("199d42df-f743-4aba-81eb-fceb18f8e21a"), 52.0, 11.4, 0.40000000000000002, 10.0, "Яблоко", 0.29999999999999999 },
                    { new Guid("25d15c60-fa8b-49fc-bf42-e7a8f9ebfcd5"), 576.0, 6.0, 49.0, 20.0, "Миндаль", 21.0 },
                    { new Guid("2cfab120-ce03-44c1-b0c4-aaafb005747c"), 18.0, 3.8999999999999999, 0.20000000000000001, 5.0, "Томат", 0.90000000000000002 },
                    { new Guid("6e9905c8-a353-4cd0-b6f5-c6c1e4d5a5a3"), 59.0, 4.7000000000000002, 3.0, 15.0, "Йогурт", 3.5 },
                    { new Guid("730cda8a-1853-4a71-a574-055be90870ce"), 208.0, 0.0, 14.300000000000001, 25.0, "Лосось", 20.0 },
                    { new Guid("84896a67-1a40-4be5-afcd-600a4a01af40"), 96.0, 21.0, 0.20000000000000001, 10.0, "Банан", 1.0 },
                    { new Guid("9e276f1a-2460-4c24-b84c-9861bf720756"), 69.0, 17.600000000000001, 0.20000000000000001, 8.0, "Виноград", 0.59999999999999998 },
                    { new Guid("b066c396-7014-4123-9ad0-fbb2eb9eafef"), 43.0, 8.1999999999999993, 0.20000000000000001, 5.0, "Апельсин", 0.90000000000000002 },
                    { new Guid("d735e46a-9d1c-440a-ac08-cd8362e00380"), 57.0, 12.699999999999999, 0.10000000000000001, 7.0, "Груша", 0.40000000000000002 },
                    { new Guid("f7c4ebda-dba9-4a2c-b69e-ea443a25cf0a"), 61.0, 14.6, 0.5, 6.0, "Киви", 1.1000000000000001 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("0b180204-52e5-4d52-a632-785a0ae884e9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("0e2c2afc-c1ee-4fb3-be6a-be57fd1769e4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("185de742-b463-4710-a23d-22c0bc0387e9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("2078c0a3-7ab6-47c2-a2d8-f478ff1e6e17"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("3726bd39-beb7-44ab-91ca-a4c5de60c391"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("48dabd4f-8da8-467b-a5be-b71928d22521"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("5c62a052-82f9-45b1-9892-edf56fdaa043"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("6efb5723-1a3d-4776-b6fb-b34c19cdb852"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("7345f12f-d3ed-40ef-8167-97779018ab3a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("78117f12-9285-489c-9386-08e35ada6579"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("911cdf9f-ab03-4aea-82cb-0ad383fa02da"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("b3d49557-8bfd-43b3-af46-b98025207676"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("bee578de-d984-4228-b4e4-3891fae1a38e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("c87ac475-2386-458f-93c3-82b20fddf048"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("199d42df-f743-4aba-81eb-fceb18f8e21a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("25d15c60-fa8b-49fc-bf42-e7a8f9ebfcd5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("2cfab120-ce03-44c1-b0c4-aaafb005747c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("6e9905c8-a353-4cd0-b6f5-c6c1e4d5a5a3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("730cda8a-1853-4a71-a574-055be90870ce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("84896a67-1a40-4be5-afcd-600a4a01af40"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("9e276f1a-2460-4c24-b84c-9861bf720756"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("b066c396-7014-4123-9ad0-fbb2eb9eafef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("d735e46a-9d1c-440a-ac08-cd8362e00380"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("f7c4ebda-dba9-4a2c-b69e-ea443a25cf0a"));

            migrationBuilder.DropColumn(
                name: "CurrentCost",
                table: "StorageProducts");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Guid", "Name" },
                values: new object[,]
                {
                    { new Guid("0400f00c-5de8-4982-9dcf-bf63011eaa67"), "Кондитерка" },
                    { new Guid("0956d6f2-f6b5-4f98-8e35-6c1389016f29"), "Орехи / Злаки / Семена" },
                    { new Guid("16792ee2-412a-412e-8922-8a1c76fff717"), "Сухофрукты" },
                    { new Guid("24252d96-1df6-4c52-ac0f-a8ea49c2889d"), "Мясо" },
                    { new Guid("41105352-c33a-4ee4-bd7a-fc775612b4d1"), "Термичка на ПЖП" },
                    { new Guid("55bcb14f-4ee1-48f1-a0db-b5c1e7af558c"), "Кофе" },
                    { new Guid("58cc1a90-2eae-4cf7-8ccf-de076c7549fc"), "Термичка растительная" },
                    { new Guid("7a687d39-ecae-4534-bc68-44e357afd8dc"), "Зелень / Овощи" },
                    { new Guid("857e1f0c-d056-43e6-8f13-d2ad054258b8"), "Вода" },
                    { new Guid("a31d0f03-53fe-4e31-ae1a-d8b624b84eea"), "Рыба / Морепродукты" },
                    { new Guid("a8388dac-c6a9-4d8d-a42f-edade76fbfbd"), "Фрукты" },
                    { new Guid("ac3d2dbd-fde7-41cc-b24e-d66f3b15a692"), "Молочка" },
                    { new Guid("fa0b03e7-251f-4d06-909a-bf970ab4c9e1"), "Соки / Чай" },
                    { new Guid("fb3a1a4c-6c3c-4bd1-923d-fa99a76a52fc"), "Яйцо" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Guid", "Caloriers", "Carb", "Fat", "HarmScore", "Name", "Prot" },
                values: new object[,]
                {
                    { new Guid("284278bc-72f8-4319-9bef-e21021b91fe4"), 18.0, 3.8999999999999999, 0.20000000000000001, 5.0, "Томат", 0.90000000000000002 },
                    { new Guid("2bf65814-578e-4cc4-9d75-50c70e7a6ca5"), 52.0, 11.4, 0.40000000000000002, 10.0, "Яблоко", 0.29999999999999999 },
                    { new Guid("53f8d448-0aca-4275-b49f-cce130d49908"), 59.0, 4.7000000000000002, 3.0, 15.0, "Йогурт", 3.5 },
                    { new Guid("60a6146f-225e-4423-aef0-9ad1641273af"), 61.0, 14.6, 0.5, 6.0, "Киви", 1.1000000000000001 },
                    { new Guid("7a1fd7b7-734d-4913-8530-132729f7f931"), 69.0, 17.600000000000001, 0.20000000000000001, 8.0, "Виноград", 0.59999999999999998 },
                    { new Guid("a443e2e3-a7c6-4519-a713-cc0813445964"), 57.0, 12.699999999999999, 0.10000000000000001, 7.0, "Груша", 0.40000000000000002 },
                    { new Guid("aec3a178-0855-45d3-8a93-005cdff59dac"), 96.0, 21.0, 0.20000000000000001, 10.0, "Банан", 1.0 },
                    { new Guid("ccbca229-f939-48f3-a45f-dda3dfc598bf"), 43.0, 8.1999999999999993, 0.20000000000000001, 5.0, "Апельсин", 0.90000000000000002 },
                    { new Guid("f315d9b9-de01-4ade-aca5-35bc481bdf45"), 576.0, 6.0, 49.0, 20.0, "Миндаль", 21.0 },
                    { new Guid("f3fcf9c8-ee1a-493a-ab75-5a2003e3817a"), 208.0, 0.0, 14.300000000000001, 25.0, "Лосось", 20.0 }
                });
        }
    }
}
