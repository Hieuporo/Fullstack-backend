using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_AspNetUsers_UserId1",
                table: "CartItems");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_UserId1",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "CartItems");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "CartItems",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fadbe714-9c56-48b8-98d9-215f1f758b7d", "AQAAAAIAAYagAAAAEOq2cKjtpYZOeVCdJMEa8Stol/gbc2HcW1+ssq6jH8JOiyzTb6k8fmynLB91Czm4iQ==", "1be32af7-536a-45d4-9e05-dae6199d8d5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee18fd7c-2c84-4dee-ba4d-bb56c3c00c07", "AQAAAAIAAYagAAAAECKZJn8tMWtbRg4pYT77XcSPbvDI0fcKZZXxPQ4DR1hkmX1ANFM5HP2Em+rE5/Gkug==", "b0decc5d-ed9e-4cc7-b077-5d8c8763a734" });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_UserId",
                table: "CartItems",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_AspNetUsers_UserId",
                table: "CartItems",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_AspNetUsers_UserId",
                table: "CartItems");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_UserId",
                table: "CartItems");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "CartItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "CartItems",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47a204e3-60ac-4caf-b657-07a27075c555", "AQAAAAIAAYagAAAAEM0TWLC05j8PIJmDIshYFbtWCjsGIqvRvdz1O+kiKt5URK1S+LcG8Pm/AErb8Qbk4w==", "9cf555c7-5b2e-4955-b874-297a4b236999" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f69286d-ae73-446f-81ad-e777b504e478", "AQAAAAIAAYagAAAAEN4kaCj+mgMSiqLaVrXXlekaO2Q6xhbNvkVePEdcSumc6eYRxauvhtzQw4hIrrJv9A==", "f412ae7f-fda5-40ef-ba0f-4063b9784f10" });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_UserId1",
                table: "CartItems",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_AspNetUsers_UserId1",
                table: "CartItems",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
