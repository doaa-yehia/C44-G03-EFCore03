using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeptAddress_City",
                table: "Department",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeptAddress_Country",
                table: "Department",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeptAddress_EmployeeEmpId",
                table: "Department",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DeptAddress_Street",
                table: "Department",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Department_DeptAddress_EmployeeEmpId",
                table: "Department",
                column: "DeptAddress_EmployeeEmpId");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Employee02_DeptAddress_EmployeeEmpId",
                table: "Department",
                column: "DeptAddress_EmployeeEmpId",
                principalTable: "Employee02",
                principalColumn: "EmpId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Employee02_DeptAddress_EmployeeEmpId",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_DeptAddress_EmployeeEmpId",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "DeptAddress_City",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "DeptAddress_Country",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "DeptAddress_EmployeeEmpId",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "DeptAddress_Street",
                table: "Department");
        }
    }
}
