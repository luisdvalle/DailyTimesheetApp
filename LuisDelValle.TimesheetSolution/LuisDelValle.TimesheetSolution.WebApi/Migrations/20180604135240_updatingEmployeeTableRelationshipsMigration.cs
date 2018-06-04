using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LuisDelValle.TimesheetSolution.WebApi.Migrations
{
    public partial class updatingEmployeeTableRelationshipsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_MangerId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_MangerId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "MangerId",
                table: "Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MangerId",
                table: "Employees",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_MangerId",
                table: "Employees",
                column: "MangerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_MangerId",
                table: "Employees",
                column: "MangerId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
