using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixCartTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23f8b676-8288-4768-bff9-f173c36fde41", "AQAAAAIAAYagAAAAEKBniWahmjfrCOuOjgPLnohNzNGMyEX26sisHrBXeikkPMCClx0O5waLEr7bWGUZUg==", "b2435fb6-36e3-4681-8e76-2881cc191f49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7787fa5-3648-4e3e-82f1-809d2775a200", "AQAAAAIAAYagAAAAEPa/uCfLjBv0aJd8fOx4eqZf+wJ/iLVaaDvucL0UETAbG/nr8Di+xJKGpHwrLyx9AQ==", "4f6c451c-5d5d-4d10-a581-f844ffd8216f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98df11ab-224a-4fa9-ac3c-968c239f80d8", "AQAAAAIAAYagAAAAEEfPoupwz4VBYQGkjqScNz/cLlR3fjrNhp9D5d9h/rZmKaiyj15DnY2WK91//1UbPg==", "19e9c90c-5438-44df-9f2e-a8931ad6883d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01cdc8c4-b40c-418f-b3ff-94d6cc9043e5", "AQAAAAIAAYagAAAAENfMqV8muSp1jyQsHwQILXpl+td1RvVmumQnyHxHq7uL1Qxvp63omvPn+nrrJC2Ieg==", "f3112fda-89aa-4bbc-9c2b-2924e77c6665" });
        }
    }
}
