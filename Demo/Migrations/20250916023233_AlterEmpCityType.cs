using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class AlterEmpCityType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "varchar(20)",
                table: "Employee02",
                newName: "EmpCity");

            migrationBuilder.AlterColumn<string>(
                name: "EmpCity",
                table: "Employee02",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmpCity",
                table: "Employee02",
                newName: "varchar(20)");

            migrationBuilder.AlterColumn<string>(
                name: "varchar(20)",
                table: "Employee02",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)");
        }
    }
}
