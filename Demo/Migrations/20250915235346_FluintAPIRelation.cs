using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class FluintAPIRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_employees_ManagerId",
                table: "Department");

            migrationBuilder.RenameColumn(
                name: "ManagerId",
                table: "Department",
                newName: "DeptManagerId");

            migrationBuilder.RenameIndex(
                name: "IX_Department_ManagerId",
                table: "Department",
                newName: "IX_Department_DeptManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_employees_DeptManagerId",
                table: "Department",
                column: "DeptManagerId",
                principalTable: "employees",
                principalColumn: "EmpId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_employees_DeptManagerId",
                table: "Department");

            migrationBuilder.RenameColumn(
                name: "DeptManagerId",
                table: "Department",
                newName: "ManagerId");

            migrationBuilder.RenameIndex(
                name: "IX_Department_DeptManagerId",
                table: "Department",
                newName: "IX_Department_ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_employees_ManagerId",
                table: "Department",
                column: "ManagerId",
                principalTable: "employees",
                principalColumn: "EmpId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
