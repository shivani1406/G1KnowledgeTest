using Microsoft.EntityFrameworkCore.Migrations;

namespace G1KnowledgeTest.DataAccess.Migrations
{
    public partial class AddQuestionstoDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Questions");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Questions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CategoryId",
                table: "Questions",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_ExamCategory_CategoryId",
                table: "Questions",
                column: "CategoryId",
                principalTable: "ExamCategory",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_ExamCategory_CategoryId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_CategoryId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Questions");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
