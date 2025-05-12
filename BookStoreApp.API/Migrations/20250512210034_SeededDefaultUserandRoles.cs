using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreApp.API.Migrations
{
    /// <inheritdoc />
    public partial class SeededDefaultUserandRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a6a4ab0-96f8-465b-8ae8-c2cd29cdd13c", null, "Admin", "ADMIN" },
                    { "e86d4b39-1cd8-4d5c-a64a-9a0e0f15b94d", null, "NormalUser", "NORMALUSER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70e930a4-49a8-43a0-b01b-2ed82eae5fb8",
                column: "Email",
                value: "user@bookstoreapp.com");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "19840b2e-e20a-43f0-ad7c-e85bb2aea1c9", 0, "k1111111-l222-m333-n444-o55555555555", "normaluser@bookstore.com", false, "System", "NormalUser", false, null, "NORMALUSER@BOOKSTORE.COM", "NORMALUSER@BOOKSTORE.COM", "1f3c53ae14626035383b39c207564d32d083e8fd", null, false, "p1111111-q222-r333-s444-t55555555555", false, "normaluser@bookstore.com" },
                    { "f7e540b1-7c6e-4a1c-8a73-35b78d79ba1b", 0, "a1111111-b222-c333-d444-e55555555555", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "1f3c53ae14626035383b39c207564d32d083e8fd", null, false, "f1111111-g222-h333-i444-j55555555555", false, "admin@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e86d4b39-1cd8-4d5c-a64a-9a0e0f15b94d", "19840b2e-e20a-43f0-ad7c-e85bb2aea1c9" },
                    { "0a6a4ab0-96f8-465b-8ae8-c2cd29cdd13c", "f7e540b1-7c6e-4a1c-8a73-35b78d79ba1b" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e86d4b39-1cd8-4d5c-a64a-9a0e0f15b94d", "19840b2e-e20a-43f0-ad7c-e85bb2aea1c9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0a6a4ab0-96f8-465b-8ae8-c2cd29cdd13c", "f7e540b1-7c6e-4a1c-8a73-35b78d79ba1b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a6a4ab0-96f8-465b-8ae8-c2cd29cdd13c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e86d4b39-1cd8-4d5c-a64a-9a0e0f15b94d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19840b2e-e20a-43f0-ad7c-e85bb2aea1c9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7e540b1-7c6e-4a1c-8a73-35b78d79ba1b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70e930a4-49a8-43a0-b01b-2ed82eae5fb8",
                column: "Email",
                value: "user@bookstore.com");
        }
    }
}
