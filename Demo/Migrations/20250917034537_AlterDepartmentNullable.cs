﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class AlterDepartmentNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Department_DeptManagerId",
                table: "Department");

            migrationBuilder.AlterColumn<int>(
                name: "DeptManagerId",
                table: "Department",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Department_DeptManagerId",
                table: "Department",
                column: "DeptManagerId",
                unique: true,
                filter: "[DeptManagerId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Department_DeptManagerId",
                table: "Department");

            migrationBuilder.AlterColumn<int>(
                name: "DeptManagerId",
                table: "Department",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Department_DeptManagerId",
                table: "Department",
                column: "DeptManagerId",
                unique: true);
        }
    }
}
