using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class Firstactualmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Jeep" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "BMW" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Mopar" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "PublishDate", "Title" },
                values: new object[] { 1, "people", "stuff", 1, "10/25/20", "topic" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "PublishDate", "Title" },
                values: new object[] { 2, "people", "stuff", 2, "10/25/20", "topic" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "PublishDate", "Title" },
                values: new object[] { 3, "people", "stuff", 3, "10/25/20", "topic" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
