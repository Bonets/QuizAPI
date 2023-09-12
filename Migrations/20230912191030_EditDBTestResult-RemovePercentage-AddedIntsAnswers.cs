using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizAPI.Migrations
{
    /// <inheritdoc />
    public partial class EditDBTestResultRemovePercentageAddedIntsAnswers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResultPercentage",
                table: "TestResults");

            migrationBuilder.RenameColumn(
                name: "TestName",
                table: "Tests",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "ResultDate",
                table: "TestResults",
                newName: "TestDate");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Questions",
                newName: "Description");

            migrationBuilder.AddColumn<int>(
                name: "RightAnswers",
                table: "TestResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalAnswers",
                table: "TestResults",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RightAnswers",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "TotalAnswers",
                table: "TestResults");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Tests",
                newName: "TestName");

            migrationBuilder.RenameColumn(
                name: "TestDate",
                table: "TestResults",
                newName: "ResultDate");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Questions",
                newName: "Title");

            migrationBuilder.AddColumn<decimal>(
                name: "ResultPercentage",
                table: "TestResults",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
