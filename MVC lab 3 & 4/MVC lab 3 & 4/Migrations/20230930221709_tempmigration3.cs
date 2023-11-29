using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_lab_3___4.Migrations
{
    /// <inheritdoc />
    public partial class tempmigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_departments_DeptNo",
                table: "students");

            migrationBuilder.AlterColumn<int>(
                name: "DeptNo",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_students_departments_DeptNo",
                table: "students",
                column: "DeptNo",
                principalTable: "departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_departments_DeptNo",
                table: "students");

            migrationBuilder.AlterColumn<int>(
                name: "DeptNo",
                table: "students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_students_departments_DeptNo",
                table: "students",
                column: "DeptNo",
                principalTable: "departments",
                principalColumn: "ID");
        }
    }
}
