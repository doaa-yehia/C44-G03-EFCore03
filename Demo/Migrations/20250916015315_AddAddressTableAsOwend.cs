using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class AddAddressTableAsOwend : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Employee02",
                newName: "EmpAddress_Street");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Employee02",
                newName: "EmpAddress_Country");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Employee02",
                newName: "EmpAddress_City");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmpAddress_Street",
                table: "Employee02",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "EmpAddress_Country",
                table: "Employee02",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "EmpAddress_City",
                table: "Employee02",
                newName: "City");
        }
    }
}
