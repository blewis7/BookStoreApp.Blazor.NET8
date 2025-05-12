using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreApp.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeededDefaultUserandRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9cd7faf3-86f2-4983-b11e-045d4a623581", "70e930a4-49a8-43a0-b01b-2ed82eae5fb8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "865474e2-bddf-4893-9581-b0f31104c01a", "c6aeae62-4d6b-4721-a9b4-3a63e4546a76" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "865474e2-bddf-4893-9581-b0f31104c01a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cd7faf3-86f2-4983-b11e-045d4a623581");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70e930a4-49a8-43a0-b01b-2ed82eae5fb8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6aeae62-4d6b-4721-a9b4-3a63e4546a76");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "865474e2-bddf-4893-9581-b0f31104c01a", null, "Administrator", "ADMINISTRATOR" },
                    { "9cd7faf3-86f2-4983-b11e-045d4a623581", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "70e930a4-49a8-43a0-b01b-2ed82eae5fb8", 0, "k1111111-l222-m333-n444-o55555555555", "user@bookstoreapp.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "1f3c53ae14626035383b39c207564d32d083e8fd", null, false, "p1111111-q222-r333-s444-t55555555555", false, "user@bookstore.com" },
                    { "c6aeae62-4d6b-4721-a9b4-3a63e4546a76", 0, "a1111111-b222-c333-d444-e55555555555", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "1f3c53ae14626035383b39c207564d32d083e8fd", null, false, "f1111111-g222-h333-i444-j55555555555", false, "admin@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "9cd7faf3-86f2-4983-b11e-045d4a623581", "70e930a4-49a8-43a0-b01b-2ed82eae5fb8" },
                    { "865474e2-bddf-4893-9581-b0f31104c01a", "c6aeae62-4d6b-4721-a9b4-3a63e4546a76" }
                });
        }
    }
}
