using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateDecimalInDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "ShippingMethods",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "ProductItems",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "OrderTotal",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "Discount",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "MinAmount",
                table: "Coupons",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountAmount",
                table: "Coupons",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c7ece50-46bc-4ed3-88d2-25e710f5aaca", "AQAAAAIAAYagAAAAEKfGmO9OEfAk5yNSvelpaNG5kBrGvv/UgaL4I83OJXijRITGflG1bYouUpo5khKfRw==", "6bc95211-95bf-466f-9f12-75f2d954ea73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7e241f9-b77f-45d4-9b9d-c07bd1ab7497", "AQAAAAIAAYagAAAAEFFjOJHxmkmwx43Pnj32krRh7Qh61N0skvwxbOppL96d+f3L5hnTUgoyEOyH689jWQ==", "04e96cf8-c00c-4ad3-a86d-d01a728c21eb" });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DiscountAmount", "MinAmount" },
                values: new object[] { 10m, 100m });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DiscountAmount", "MinAmount" },
                values: new object[] { 20m, 150m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "ShippingMethods",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "ProductItems",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "OrderTotal",
                table: "Orders",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "Discount",
                table: "Orders",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "MinAmount",
                table: "Coupons",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "DiscountAmount",
                table: "Coupons",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f98b81f-060d-4c65-9b8c-ac2eab3e3160", "AQAAAAIAAYagAAAAEChiNP6kA5Hbh6XybzqVrspJguso7hgKZbJNgkOOth4admGI8/H/czjtSc6sOW0FXg==", "4cc04af3-51c7-4a6c-964e-f2bae586ad5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b732cdf4-a322-446b-b94c-baa5afab689a", "AQAAAAIAAYagAAAAEGyn/yNKtEm+BAOTKC+BcfmkAZaiYZ1GxPqVMZc0+AMtedTAkfYhJfKOmM6q8z/KZA==", "4a99ada2-2cdf-4cf2-bbb0-7e13a13ada1f" });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DiscountAmount", "MinAmount" },
                values: new object[] { 10.0, 100.0 });

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DiscountAmount", "MinAmount" },
                values: new object[] { 20.0, 150.0 });
        }
    }
}
