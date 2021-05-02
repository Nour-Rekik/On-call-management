using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class OneToManymigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartementId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartementId",
                table: "Employees",
                column: "DepartementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departements_DepartementId",
                table: "Employees",
                column: "DepartementId",
                principalTable: "Departements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departements_DepartementId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartementId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartementId",
                table: "Employees");
        }
    }
}
