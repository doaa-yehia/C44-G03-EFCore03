using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class FluintAPIRelation02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_employees_DeptManagerId",
                table: "Department");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_employees_DeptManagerId",
                table: "Department",
                column: "DeptManagerId",
                principalTable: "employees",
                principalColumn: "EmpId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_employees_DeptManagerId",
                table: "Department");

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
