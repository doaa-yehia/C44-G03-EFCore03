using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class AddAddressTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_employees_DeptManagerId",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_employees",
                table: "employees");

            migrationBuilder.RenameTable(
                name: "employees",
                newName: "Employee02");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Employee02",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Employee02",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Employee02",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee02",
                table: "Employee02",
                column: "EmpId");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Employee02_DeptManagerId",
                table: "Department",
                column: "DeptManagerId",
                principalTable: "Employee02",
                principalColumn: "EmpId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Employee02_DeptManagerId",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee02",
                table: "Employee02");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Employee02");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Employee02");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Employee02");

            migrationBuilder.RenameTable(
                name: "Employee02",
                newName: "employees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_employees",
                table: "employees",
                column: "EmpId");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_employees_DeptManagerId",
                table: "Department",
                column: "DeptManagerId",
                principalTable: "employees",
                principalColumn: "EmpId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
