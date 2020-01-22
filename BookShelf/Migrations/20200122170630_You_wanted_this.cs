using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShelf.Migrations
{
    public partial class You_wanted_this : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8e734b98-86ed-4c93-8129-d8a677f7e1de", "AQAAAAEAACcQAAAAEHhFAbDAef+AkYBFWR9FFGH2iE9Wq+DY+p33vU0di1LDLc13e/yr8apy7y9fLYcz0Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1b584bf6-a488-4c67-a625-3a0811c3c331", "AQAAAAEAACcQAAAAECDAfRPvw9XKw1Lppg4Sw3ormu0VQRPN2AEKr7WbdleCxoZrVwP+rimfSgHIx/5RJw==" });
        }
    }
}
