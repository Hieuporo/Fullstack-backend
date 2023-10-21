using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Carts_CartId",
                table: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems");

            migrationBuilder.RenameColumn(
                name: "CartId",
                table: "CartItems",
                newName: "UserId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "CartItems",
                newName: "CartId");

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Carts_CartId",
                table: "CartItems",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
