using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    /// <inheritdoc />
    public partial class AnotherUpdateSeededDefaultChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a6a4ab0-96f8-465b-8ae8-c2cd29cdd13c",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e86d4b39-1cd8-4d5c-a64a-9a0e0f15b94d",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19840b2e-e20a-43f0-ad7c-e85bb2aea1c9",
                columns: new[] { "Email", "LastName", "NormalizedEmail", "NormalizedUserName", "UserName" },
                values: new object[] { "user@bookstore.com", "User", "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "user@bookstore.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a6a4ab0-96f8-465b-8ae8-c2cd29cdd13c",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e86d4b39-1cd8-4d5c-a64a-9a0e0f15b94d",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "NormalUser", "NORMALUSER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19840b2e-e20a-43f0-ad7c-e85bb2aea1c9",
                columns: new[] { "Email", "LastName", "NormalizedEmail", "NormalizedUserName", "UserName" },
                values: new object[] { "normaluser@bookstore.com", "NormalUser", "NORMALUSER@BOOKSTORE.COM", "NORMALUSER@BOOKSTORE.COM", "normaluser@bookstore.com" });
        }
    }
}
