using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "AvatarPictureUrl",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "AvatarUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "FirstName", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "714758e1-2607-4671-a78e-2e38408f2091", "Admin", "AQAAAAIAAYagAAAAEMGof46DqOiMC/oduHDXme3kS6fL5dGz5fJXLSl828rUe1E6ax9k0E96XBpDqqN3Tw==", "7090293b-b99e-47fa-8402-e0037065134e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "AvatarUrl", "ConcurrencyStamp", "FirstName", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "a3d276bd-972c-4adb-928b-ab758891f736", "User", "AQAAAAIAAYagAAAAED8kOfKzkfvtKRlmK+F5Txi8j69omLRFSFe9lDqFnlnRX+0sVXVmny3R71WqZzuMTw==", "4f60bc1c-ead2-439f-ab49-e37c9d0f6a42" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvatarUrl",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "AvatarPictureUrl");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "Name", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f284fe46-6036-4e53-a634-5793a91516fc", "Admin", "AQAAAAIAAYagAAAAEJNLztXg7M1CnZfP1Dfv6/bEOjV1Dc3C2CaeQbzUyC+BEECplr7/BwqaeZvUu4PuXg==", "2cdf5f6f-68a0-4f17-99a9-0094818748fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "Name", "PasswordHash", "SecurityStamp" },
                values: new object[] { "406bb60b-738a-4009-8f52-c7775b90cb81", "User", "AQAAAAIAAYagAAAAEGESu3edP3QPHUTkXV+e+73g6X4+LFlDelS/d9QXZ+jflsHKxLb9yeRNAlxt7gFdRA==", "bdd22c6d-efb8-4e0b-a516-8ad2c182ca8c" });
        }
    }
}
