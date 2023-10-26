using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class upadteOrderTb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StripeSessionId",
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
                values: new object[] { "a9a6c0e8-0663-4cda-9012-365bdcd4e76d", "AQAAAAIAAYagAAAAEEvS/dHmUM8BSZJyZlog7o5C/qMVryMXPBNdyVIm0rdrXyqocPjKuG/mjSCy4Jycug==", "31d20878-afb7-4a90-8bdf-f036d5a2f032" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cdbeb3c-150e-44bf-9800-83fbd88aabdd", "AQAAAAIAAYagAAAAENt/qKVWJyRTYp5usiLFNkT8HaPQs/NcoIQhe0JcmOjLeT0wfJTGcgEzAFAERnhUDQ==", "3e0f1928-75ac-4231-9347-6a94847c7d19" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
