using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShelf.Migrations
{
    public partial class Add_User_Book : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1b584bf6-a488-4c67-a625-3a0811c3c331", "AQAAAAEAACcQAAAAECDAfRPvw9XKw1Lppg4Sw3ormu0VQRPN2AEKr7WbdleCxoZrVwP+rimfSgHIx/5RJw==" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "ApplicationUserId", "Name" },
                values: new object[,]
                {
                    { 1, "00000000-ffff-ffff-ffff-ffffffffffff", "Jimmy John" },
                    { 2, "00000000-ffff-ffff-ffff-ffffffffffff", "Jersey Mike" },
                    { 3, "00000000-ffff-ffff-ffff-ffffffffffff", "Jared Fogle" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "ApplicationUserId", "AuthorId", "Genre", "Rating", "Title", "YearPublished" },
                values: new object[] { 1, "00000000-ffff-ffff-ffff-ffffffffffff", 1, "Fantasy", 1, "Free Smells", 1990 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "ApplicationUserId", "AuthorId", "Genre", "Rating", "Title", "YearPublished" },
                values: new object[] { 2, "00000000-ffff-ffff-ffff-ffffffffffff", 2, "Sandwiches", 2, "Jersey Subs", 2020 });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "ApplicationUserId", "AuthorId", "Genre", "Rating", "Title", "YearPublished" },
                values: new object[] { 3, "00000000-ffff-ffff-ffff-ffffffffffff", 3, "Instructional", 1, "How to make a prison sandwiche", 2013 });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "ApplicationUserId", "BookId", "Text" },
                values: new object[] { 2, "00000000-ffff-ffff-ffff-ffffffffffff", 1, "Best book ever!" });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "ApplicationUserId", "BookId", "Text" },
                values: new object[] { 1, "00000000-ffff-ffff-ffff-ffffffffffff", 2, "It smells like Jersey" });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "ApplicationUserId", "BookId", "Text" },
                values: new object[] { 3, "00000000-ffff-ffff-ffff-ffffffffffff", 3, "How did he write this book???" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d9a532bd-9b91-40de-8b4c-8e6f395c298d", "AQAAAAEAACcQAAAAEAbXoUKPUz/cOim/DXtTjKHNhnU9UM9euDJivBCWVcTZuBwDPi98oBCYPSNk/jOQUQ==" });
        }
    }
}
