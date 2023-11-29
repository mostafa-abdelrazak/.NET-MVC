using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_lab_3___4.Migrations
{
    /// <inheritdoc />
    public partial class tempmigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "departments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "departments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
