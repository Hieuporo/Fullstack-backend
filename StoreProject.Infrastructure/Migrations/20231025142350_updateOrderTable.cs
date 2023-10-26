using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateOrderTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StripeSessionId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PaymentIntentId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40e7cf6d-211a-4967-b72d-4edb3196f128", "AQAAAAIAAYagAAAAEFPgOk7FTWqlgP0eDrJf+MojzbTyuMXetpL/XaJQewswPz7MOgl1K1ys8U8obHlCOA==", "0699b438-c0ee-467f-b631-e18f2369e9ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f60ea9b8-ca54-4809-89c9-b57f34b1ffa0", "AQAAAAIAAYagAAAAEKCfKNV+DIeB7Zkd6s3VNmn/vRcFsu8mW1w0m8cpGuf248916at4lyGOkoYpuWCXyw==", "8739f0a5-35d3-46f0-9481-a10ed7cb540d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StripeSessionId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentIntentId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
