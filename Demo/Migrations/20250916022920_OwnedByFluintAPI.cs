using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class OwnedByFluintAPI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmpAddress_City",
                table: "Employee02",
                newName: "varchar(20)");

            migrationBuilder.RenameColumn(
                name: "DeptAddress_City",
                table: "Department",
                newName: "DeptCity");

            migrationBuilder.AlterColumn<string>(
                name: "varchar(20)",
                table: "Employee02",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeptCity",
                table: "Department",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "varchar(20)",
                table: "Employee02",
                newName: "EmpAddress_City");

            migrationBuilder.RenameColumn(
                name: "DeptCity",
                table: "Department",
                newName: "DeptAddress_City");

            migrationBuilder.AlterColumn<string>(
                name: "EmpAddress_City",
                table: "Employee02",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DeptAddress_City",
                table: "Department",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);
        }
    }
}
