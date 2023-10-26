using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateOrderItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "OrderItems");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "OrderItems",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca13a858-8aad-4faa-bf0c-e85f002844f9", "AQAAAAIAAYagAAAAEMfbEAAMIurFfLH90fw95WlZCR4LGyC9gnBXdfFHFus0/1Yhpo8JM/lLS/31SLushw==", "2a7a09cd-884a-486e-bdd0-c701ef121c1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0779aaea-ba24-4441-9d73-5e9432689181", "AQAAAAIAAYagAAAAEJmOH4pmksFeDUdgMXyyUPpCtghoMX1P2dkCb6jTFUPA0JnxOWdyrd5TN/XvuQxANg==", "df595650-c183-4646-9eed-a2f1b716484a" });
        }
    }
}
