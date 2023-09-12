using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizAPI.Migrations
{
    /// <inheritdoc />
    public partial class EditDBStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTestQuestionAnswers_Tests_TestId",
                table: "UserTestQuestionAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTestQuestionAnswers_Users_UserId",
                table: "UserTestQuestionAnswers");

            migrationBuilder.DropIndex(
                name: "IX_UserTestQuestionAnswers_TestId",
                table: "UserTestQuestionAnswers");

            migrationBuilder.DropColumn(
                name: "TestId",
                table: "UserTestQuestionAnswers");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserTestQuestionAnswers",
                newName: "TestResultId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTestQuestionAnswers_UserId",
                table: "UserTestQuestionAnswers",
                newName: "IX_UserTestQuestionAnswers_TestResultId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserTestQuestionAnswers_TestResults_TestResultId",
                table: "UserTestQuestionAnswers",
                column: "TestResultId",
                principalTable: "TestResults",
                principalColumn: "TestResultId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTestQuestionAnswers_TestResults_TestResultId",
                table: "UserTestQuestionAnswers");

            migrationBuilder.RenameColumn(
                name: "TestResultId",
                table: "UserTestQuestionAnswers",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTestQuestionAnswers_TestResultId",
                table: "UserTestQuestionAnswers",
                newName: "IX_UserTestQuestionAnswers_UserId");

            migrationBuilder.AddColumn<int>(
                name: "TestId",
                table: "UserTestQuestionAnswers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserTestQuestionAnswers_TestId",
                table: "UserTestQuestionAnswers",
                column: "TestId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserTestQuestionAnswers_Tests_TestId",
                table: "UserTestQuestionAnswers",
                column: "TestId",
                principalTable: "Tests",
                principalColumn: "TestId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTestQuestionAnswers_Users_UserId",
                table: "UserTestQuestionAnswers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
