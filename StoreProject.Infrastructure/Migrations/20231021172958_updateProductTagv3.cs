using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateProductTagv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a89bef04-94cc-4cdc-b9f1-9ae0f07b4129", "AQAAAAIAAYagAAAAEEySRa7vTahH80ixtnKPsUdtNU8GsTHKTZAKW+l8pqCV43j/RAG5KnwZpY3r6a/c6A==", "5cd6b360-1122-4a7a-9cb9-759915e9b715" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5fc0511-8e6f-4ac1-9683-045ec4c18373", "AQAAAAIAAYagAAAAEDjWyOHXGketYT0ZGYYrth8uBJHu5qZaqVRffZFsJnauDzuoIA0984NLf0lYX3+wDg==", "8cb0b254-2151-492f-a33a-b9cb9e6c6487" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
