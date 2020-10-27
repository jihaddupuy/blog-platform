using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "jake" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "jake" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "PublishDate", "Title" },
                values: new object[] { 1, "people", "stuff", 1, "10/25/20", "topic" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "PublishDate", "Title" },
                values: new object[] { 2, "people", "stuff", 2, "10/25/20", "topic" });
        }
    }
}
