using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodLog.DAL.Migrations
{
    /// <inheritdoc />
    public partial class TrashToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("1b769573-9e4d-441c-9b45-ebf11ed78752"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("26ceb232-1356-45c5-8fb7-43430bce3017"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("3391cf38-ad05-4447-b62e-308b6443154a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("380b3515-1574-428b-86ea-f4b2ce929b49"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("38596f96-0db6-42c3-9a08-7dbf3ac42cb3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("4a07ae8f-b1c4-4c7c-88b0-1d3444b72044"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("5bed2328-662e-4430-963e-5d163919a4e5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("993fe1e7-8946-4921-bac0-8fc1ec2c105d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("a5ac5444-8cb5-49ae-9e36-2b4c393df02d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("a84c6fe9-a689-435b-b29d-ba3650e17102"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("b359abb3-e9f2-4937-a15e-784a637c91b9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("d6eb2e31-1767-4899-96a0-c9dd884d2b4f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("da829d2d-78da-4bca-9042-a1ba4bef34ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Guid",
                keyValue: new Guid("fdec60f7-4d03-4a6b-b6cc-0ab4ba97d5cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("2b5db54e-5c2c-4dcc-bf0f-3d6bb5c59095"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("32a10e87-49fe-4b28-b7f2-a14c0c237946"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("45b6ae1a-0323-44bb-b110-0020e48d94cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("84696186-6697-49de-8844-42ad8347fd15"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("9a12113b-b5e8-4ce5-bcba-f469bc62fb58"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("9bcc4f3a-d20a-480a-aa63-23f1a298c515"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("acdd3326-7cd1-47d1-a181-bf13cd976a74"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("ad0df4d9-eec2-4fe3-9656-44427eb27d6a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("cd3a90bc-6cb8-4733-b15f-ce0401a08a89"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Guid",
                keyValue: new Guid("ef16d6da-9a1b-487b-bfed-6226f82243f6"));

            migrationBuilder.AddColumn<double>(
                name: "TrashPercentage",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "TrashPercentage",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Guid", "Name" },
                values: new object[,]
                {
                    { new Guid("1b769573-9e4d-441c-9b45-ebf11ed78752"), "Вода" },
                    { new Guid("26ceb232-1356-45c5-8fb7-43430bce3017"), "Термичка растительная" },
                    { new Guid("3391cf38-ad05-4447-b62e-308b6443154a"), "Кондитерка" },
                    { new Guid("380b3515-1574-428b-86ea-f4b2ce929b49"), "Молочка" },
                    { new Guid("38596f96-0db6-42c3-9a08-7dbf3ac42cb3"), "Рыба / Морепродукты" },
                    { new Guid("4a07ae8f-b1c4-4c7c-88b0-1d3444b72044"), "Мясо" },
                    { new Guid("5bed2328-662e-4430-963e-5d163919a4e5"), "Орехи / Злаки / Семена" },
                    { new Guid("993fe1e7-8946-4921-bac0-8fc1ec2c105d"), "Фрукты" },
                    { new Guid("a5ac5444-8cb5-49ae-9e36-2b4c393df02d"), "Яйцо" },
                    { new Guid("a84c6fe9-a689-435b-b29d-ba3650e17102"), "Соки / Чай" },
                    { new Guid("b359abb3-e9f2-4937-a15e-784a637c91b9"), "Термичка на ПЖП" },
                    { new Guid("d6eb2e31-1767-4899-96a0-c9dd884d2b4f"), "Кофе" },
                    { new Guid("da829d2d-78da-4bca-9042-a1ba4bef34ac"), "Зелень / Овощи" },
                    { new Guid("fdec60f7-4d03-4a6b-b6cc-0ab4ba97d5cf"), "Сухофрукты" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Guid", "Caloriers", "Carb", "Fat", "HarmScore", "Name", "Prot" },
                values: new object[,]
                {
                    { new Guid("2b5db54e-5c2c-4dcc-bf0f-3d6bb5c59095"), 208.0, 0.0, 14.300000000000001, 25.0, "Лосось", 20.0 },
                    { new Guid("32a10e87-49fe-4b28-b7f2-a14c0c237946"), 61.0, 14.6, 0.5, 6.0, "Киви", 1.1000000000000001 },
                    { new Guid("45b6ae1a-0323-44bb-b110-0020e48d94cc"), 43.0, 8.1999999999999993, 0.20000000000000001, 5.0, "Апельсин", 0.90000000000000002 },
                    { new Guid("84696186-6697-49de-8844-42ad8347fd15"), 69.0, 17.600000000000001, 0.20000000000000001, 8.0, "Виноград", 0.59999999999999998 },
                    { new Guid("9a12113b-b5e8-4ce5-bcba-f469bc62fb58"), 59.0, 4.7000000000000002, 3.0, 15.0, "Йогурт", 3.5 },
                    { new Guid("9bcc4f3a-d20a-480a-aa63-23f1a298c515"), 18.0, 3.8999999999999999, 0.20000000000000001, 5.0, "Томат", 0.90000000000000002 },
                    { new Guid("acdd3326-7cd1-47d1-a181-bf13cd976a74"), 52.0, 11.4, 0.40000000000000002, 10.0, "Яблоко", 0.29999999999999999 },
                    { new Guid("ad0df4d9-eec2-4fe3-9656-44427eb27d6a"), 57.0, 12.699999999999999, 0.10000000000000001, 7.0, "Груша", 0.40000000000000002 },
                    { new Guid("cd3a90bc-6cb8-4733-b15f-ce0401a08a89"), 96.0, 21.0, 0.20000000000000001, 10.0, "Банан", 1.0 },
                    { new Guid("ef16d6da-9a1b-487b-bfed-6226f82243f6"), 576.0, 6.0, 49.0, 20.0, "Миндаль", 21.0 }
                });
        }
    }
}
