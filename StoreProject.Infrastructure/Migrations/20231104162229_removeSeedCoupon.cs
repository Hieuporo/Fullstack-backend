using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StoreProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class removeSeedCoupon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "297416f7-4f99-4910-b243-39e7e5f77a75", "AQAAAAIAAYagAAAAEAN1Jkh0EVn1qGGIGmIv+evwgt8wljs5+FM9jQGrJmFFHXjWUsjDiKilDcLCwMPUUQ==", "e36a4a10-b2e2-4d08-a6f6-3b3ffef900b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0050879-dff1-4b31-a842-44996a13f528", "AQAAAAIAAYagAAAAEKis+fAF5EjsjC4lQIhPr9qOZNSv9fH56waLKUUZwFnDHH35q8xbPtrVodnR/xk5mA==", "14da26ef-5799-4a0f-a851-3464c3a902c0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "Id", "CouponCode", "CreatedAt", "CreatedBy", "DiscountAmount", "LastModified", "LastModifiedBy", "MinAmount" },
                values: new object[,]
                {
                    { 1, "100FF", null, null, 10m, null, null, 100m },
                    { 2, "200FF", null, null, 20m, null, null, 150m }
                });
        }
    }
}
