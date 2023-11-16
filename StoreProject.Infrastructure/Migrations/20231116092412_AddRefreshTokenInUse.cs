using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddRefreshTokenInUse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AvatarPictureUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastLogin",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiry",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "AvatarPictureUrl", "ConcurrencyStamp", "LastLogin", "PasswordHash", "RefreshToken", "RefreshTokenExpiry", "SecurityStamp" },
                values: new object[] { null, "aeb9403f-1b79-42ae-a2ff-5735f1b107f4", null, "AQAAAAIAAYagAAAAEDgc2drFeHzmqh4hPIJY/Hg3pznc7syexgsmOlnnIxeyF35QW74OghdjPJ7pelwdWw==", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8e4aaa24-299b-4fc1-b53b-45f92be12cf0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "AvatarPictureUrl", "ConcurrencyStamp", "LastLogin", "PasswordHash", "RefreshToken", "RefreshTokenExpiry", "SecurityStamp" },
                values: new object[] { null, "4006b810-e4f8-40fb-9f33-43c7c9df2345", null, "AQAAAAIAAYagAAAAENFNtuImD3pPGZYay6WHxpifkXfJeie55Whx+TfjeFt7Fu4r4Xiefx5KTtv2cdGXaQ==", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c7cc543c-91df-4ee5-86bb-48e58e7beb6b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvatarPictureUrl",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastLogin",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiry",
                table: "AspNetUsers");

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
    }
}
