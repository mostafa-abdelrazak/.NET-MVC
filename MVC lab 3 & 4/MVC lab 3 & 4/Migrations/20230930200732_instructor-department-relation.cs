using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_lab_3___4.Migrations
{
    /// <inheritdoc />
    public partial class instructordepartmentrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instructor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentInstructor",
                columns: table => new
                {
                    DepartmentsID = table.Column<int>(type: "int", nullable: false),
                    InstructorsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentInstructor", x => new { x.DepartmentsID, x.InstructorsID });
                    table.ForeignKey(
                        name: "FK_DepartmentInstructor_Instructor_InstructorsID",
                        column: x => x.InstructorsID,
                        principalTable: "Instructor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentInstructor_departments_DepartmentsID",
                        column: x => x.DepartmentsID,
                        principalTable: "departments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentInstructor_InstructorsID",
                table: "DepartmentInstructor",
                column: "InstructorsID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentInstructor");

            migrationBuilder.DropTable(
                name: "Instructor");
        }
    }
}
