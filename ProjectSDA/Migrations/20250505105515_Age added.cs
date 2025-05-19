using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectSDA.Migrations
{
    /// <inheritdoc />
    public partial class Ageadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "Student");
        }
    }
}
