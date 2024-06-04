using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCRUDApp.Migrations
{
    /// <inheritdoc />
    public partial class Updated_EmployeeHistory_removed_employee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeHistory_Employee_EmployeeId",
                table: "EmployeeHistory");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeHistory_EmployeeId",
                table: "EmployeeHistory");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "EmployeeHistory");

            migrationBuilder.AddColumn<string>(
                name: "Employee",
                table: "EmployeeHistory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Employee",
                table: "EmployeeHistory");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "EmployeeHistory",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeHistory_EmployeeId",
                table: "EmployeeHistory",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeHistory_Employee_EmployeeId",
                table: "EmployeeHistory",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id");
        }
    }
}
