using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class fixedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Contents_ContentID",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Contents_ContentId",
                table: "Contents");

            migrationBuilder.DropIndex(
                name: "IX_Contents_ContentId",
                table: "Contents");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ContentID",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ContentId",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "ContentID",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Contents",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contents_CategoryId",
                table: "Contents",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Categories_CategoryId",
                table: "Contents",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Categories_CategoryId",
                table: "Contents");

            migrationBuilder.DropIndex(
                name: "IX_Contents_CategoryId",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Contents");

            migrationBuilder.AddColumn<int>(
                name: "ContentId",
                table: "Contents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContentID",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contents_ContentId",
                table: "Contents",
                column: "ContentId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ContentID",
                table: "Categories",
                column: "ContentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Contents_ContentID",
                table: "Categories",
                column: "ContentID",
                principalTable: "Contents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Contents_ContentId",
                table: "Contents",
                column: "ContentId",
                principalTable: "Contents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
