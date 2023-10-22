using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateEntities77 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTags",
                table: "ProductTags");

            migrationBuilder.DropIndex(
                name: "IX_ProductTags_ProductId",
                table: "ProductTags");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ProductTags",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTags",
                table: "ProductTags",
                columns: new[] { "ProductId", "TagId" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f07664b5-8c75-4c04-8064-8e0a5719cc85", "AQAAAAIAAYagAAAAEEzDwDYxT3m1kcazYRR3SMPW75vTxZ3OzIvVmDcxdwPHY61fljpQ7ZShb8SoRdZA/w==", "2d4e0639-d8aa-4661-a324-b6821b42742f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fc25bc6-94ca-4a57-9095-e0cc122304de", "AQAAAAIAAYagAAAAEMkuoFsh3uD7E0BszAPf1EPhRNK6Am66UrgZz2Z4kb6g6PRg3BqeXgdvNObC90GEMA==", "28d49a6f-8bf0-4184-a5b8-ef82009a722b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTags",
                table: "ProductTags");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ProductTags",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTags",
                table: "ProductTags",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b90a17ca-bca9-42c0-b2f6-f41e8c5ceda6", "AQAAAAIAAYagAAAAENixjjAYHM4KJkevxL0a8S96qKxh1g9gfvp3mMzvO+TJA3Af6gSitySbxAi88nVTLQ==", "c35b4e26-1bd7-4a40-b61c-cd1890df7858" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd84fc83-6e1c-4bec-bbe0-954ded178a3d", "AQAAAAIAAYagAAAAEEEMISx4Bhu1tA5tqKGyv3Xw3qELbNXe8w8jNVK7Uo/mN7iHMNgw0XmSCKM2xjgQ7Q==", "34712a93-e503-4d17-88f1-cea5b6bffc99" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_ProductId",
                table: "ProductTags",
                column: "ProductId");
        }
    }
}
