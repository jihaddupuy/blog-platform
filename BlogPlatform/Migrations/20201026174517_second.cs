using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Contents_ContentID",
                table: "Categories");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "ContentID",
                table: "Categories",
                newName: "ContentId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_ContentID",
                table: "Categories",
                newName: "IX_Categories_ContentId");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Contents",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ContentId",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ContentID",
                table: "Categories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Contents_ContentId",
                table: "Categories",
                column: "ContentId",
                principalTable: "Contents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Contents_ContentId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "ContentID",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "ContentId",
                table: "Categories",
                newName: "ContentID");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_ContentId",
                table: "Categories",
                newName: "IX_Categories_ContentID");

            migrationBuilder.AlterColumn<int>(
                name: "ContentID",
                table: "Categories",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "ContentId", "PublishDate", "Title" },
                values: new object[] { 1, "crying mechanic", "work when they want", 1, "10/25/20", "cars" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "ContentId", "PublishDate", "Title" },
                values: new object[] { 2, "crying owner", " costing me to much money", null, "10/25/20", "jeeps" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ContentID", "Name" },
                values: new object[] { 1, 1, "jake" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ContentID", "Name" },
                values: new object[] { 2, 2, "jihad" });

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Contents_ContentID",
                table: "Categories",
                column: "ContentID",
                principalTable: "Contents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
