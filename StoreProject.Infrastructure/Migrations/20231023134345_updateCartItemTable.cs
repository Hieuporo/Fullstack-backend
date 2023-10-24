using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateCartItemTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "CartItems");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "CartItems",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52003da8-e724-477d-8a25-dd891709e090", "AQAAAAIAAYagAAAAEF1tTKGwRodR+TCPTl9CVJ48aOP0YE45Qa/zeglCW1Rode5c54D6TQbw1tLdLpqLKw==", "2c7b81a7-26ac-4f68-bd32-d78095aa5684" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9f013d7-4e48-4d1c-832d-3a424ebc0699", "AQAAAAIAAYagAAAAEA1OSbhdbyR5VgzN4Njvc93/h4F36DdE5jUO+aauivUABKwVU8UTczQrzgbtq0qhkQ==", "6228b741-1599-4a97-b05c-1796e868bf1f" });
        }
    }
}
