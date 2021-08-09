using Microsoft.EntityFrameworkCore.Migrations;

namespace UPS.Data.Migrations
{
    public partial class entities2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Courses_CourseId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Expenses_ExpenseId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "ExpensesCourses");

            migrationBuilder.RenameIndex(
                name: "IX_Users_ExpenseId",
                table: "ExpensesCourses",
                newName: "IX_ExpensesCourses_ExpenseId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CourseId",
                table: "ExpensesCourses",
                newName: "IX_ExpensesCourses_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExpensesCourses",
                table: "ExpensesCourses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpensesCourses_Courses_CourseId",
                table: "ExpensesCourses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExpensesCourses_Expenses_ExpenseId",
                table: "ExpensesCourses",
                column: "ExpenseId",
                principalTable: "Expenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpensesCourses_Courses_CourseId",
                table: "ExpensesCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpensesCourses_Expenses_ExpenseId",
                table: "ExpensesCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExpensesCourses",
                table: "ExpensesCourses");

            migrationBuilder.RenameTable(
                name: "ExpensesCourses",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_ExpensesCourses_ExpenseId",
                table: "Users",
                newName: "IX_Users_ExpenseId");

            migrationBuilder.RenameIndex(
                name: "IX_ExpensesCourses_CourseId",
                table: "Users",
                newName: "IX_Users_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Courses_CourseId",
                table: "Users",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Expenses_ExpenseId",
                table: "Users",
                column: "ExpenseId",
                principalTable: "Expenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
