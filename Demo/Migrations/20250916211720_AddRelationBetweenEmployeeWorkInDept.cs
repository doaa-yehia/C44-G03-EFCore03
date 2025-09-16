using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationBetweenEmployeeWorkInDept : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Employee02",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeptId",
                table: "Employee02",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employee02_DepartmentId",
                table: "Employee02",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee02_DeptId",
                table: "Employee02",
                column: "DeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee02_Department_DepartmentId",
                table: "Employee02",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee02_Department_DeptId",
                table: "Employee02",
                column: "DeptId",
                principalTable: "Department",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee02_Department_DepartmentId",
                table: "Employee02");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee02_Department_DeptId",
                table: "Employee02");

            migrationBuilder.DropIndex(
                name: "IX_Employee02_DepartmentId",
                table: "Employee02");

            migrationBuilder.DropIndex(
                name: "IX_Employee02_DeptId",
                table: "Employee02");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Employee02");

            migrationBuilder.DropColumn(
                name: "DeptId",
                table: "Employee02");
        }
    }
}
