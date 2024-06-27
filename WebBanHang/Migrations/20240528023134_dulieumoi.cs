using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBanHang.Migrations
{
    public partial class dulieumoi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[] { 1, 1, "Dell" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[] { 2, 2, "Asus" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[] { 3, 3, "Macbook" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, null, null, "Laptop Dell Inspiron 15 3520 i5", 1300.0 },
                    { 2, 1, null, null, "Laptop Dell Vostro 15 3520 i5", 1500.0 },
                    { 3, 1, null, null, "Laptop Dell Inspiron 15 3520 i3", 1400.0 },
                    { 4, 1, null, null, "Laptop Dell Vostro 15 3520 i3", 1800.0 },
                    { 5, 1, null, null, "Laptop Asus Vivobook Go 15", 1650.0 },
                    { 6, 1, null, null, "Laptop Asus Vivobook 15 X1504ZA i3", 1750.0 },
                    { 7, 1, null, null, "Laptop Asus Vivobook 15 OLED A1505ZA i5", 2850.0 },
                    { 8, 1, null, null, "Laptop Asus TUF Gaming F15 FX507ZC4 i5", 2950.0 },
                    { 9, 1, null, null, "Laptop Apple MacBook Air 13 inch M1", 3200.0 },
                    { 10, 1, null, null, "Laptop Apple MacBook Air 13 inch M2", 2450.0 },
                    { 11, 2, null, null, "Laptop Apple MacBook Air 15 inch M2", 2500.0 },
                    { 12, 2, null, null, "Laptop Apple MacBook Pro 14 inch M3", 1250.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
