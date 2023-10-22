using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateProductTagv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ProductTags");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ProductTags");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProductTags");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "ProductTags");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "ProductTags");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6755042c-5be4-42ab-b088-5d00e0ae73f6", "AQAAAAIAAYagAAAAEDBaGjjS0Hejtrs4au0rSGgIHXetyFOAjZwwFSTc+MvSo1DwTZUOszAf6pxnRqasQg==", "05f7afc3-c500-44aa-8027-b627243c5505" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef88820f-a56e-4356-aac0-76a5ec5f51d0", "AQAAAAIAAYagAAAAEHXNq85zVAlejYqSsliLdQl7avsF2awbFZdvufFoJkETA99TiRc2VI5Uf3vEVogIcw==", "fcd49148-c02b-4b1c-b854-4dcd234ea04e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductTags",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ProductTags",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ProductTags",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "ProductTags",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "ProductTags",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
