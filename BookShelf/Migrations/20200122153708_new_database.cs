using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShelf.Migrations
{
    public partial class new_database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "00000000-ffff-ffff-ffff-ffffffffffff", 0, "d9a532bd-9b91-40de-8b4c-8e6f395c298d", "admin@admin.com", true, "admin", "admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEAbXoUKPUz/cOim/DXtTjKHNhnU9UM9euDJivBCWVcTZuBwDPi98oBCYPSNk/jOQUQ==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "admin@admin.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff");
        }
    }
}
