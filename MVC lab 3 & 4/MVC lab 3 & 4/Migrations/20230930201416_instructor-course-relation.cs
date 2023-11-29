using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_lab_3___4.Migrations
{
    /// <inheritdoc />
    public partial class instructorcourserelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentInstructor_Instructor_InstructorsID",
                table: "DepartmentInstructor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor");

            migrationBuilder.RenameTable(
                name: "Instructor",
                newName: "Instructors");

            migrationBuilder.AddColumn<int>(
                name: "InstructorId",
                table: "courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Instructors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_courses_InstructorId",
                table: "courses",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_Instructors_InstructorId",
                table: "courses",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentInstructor_Instructors_InstructorsID",
                table: "DepartmentInstructor",
                column: "InstructorsID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_Instructors_InstructorId",
                table: "courses");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentInstructor_Instructors_InstructorsID",
                table: "DepartmentInstructor");

            migrationBuilder.DropIndex(
                name: "IX_courses_InstructorId",
                table: "courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "courses");

            migrationBuilder.RenameTable(
                name: "Instructors",
                newName: "Instructor");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Instructor",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentInstructor_Instructor_InstructorsID",
                table: "DepartmentInstructor",
                column: "InstructorsID",
                principalTable: "Instructor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
