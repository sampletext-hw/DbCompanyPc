using Microsoft.EntityFrameworkCore.Migrations;

namespace DbCompanyPc.Data.Migrations
{
    public partial class addlocalnetworkdepartmentrelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "LocalNetworks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LocalNetworks_DepartmentId",
                table: "LocalNetworks",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_LocalNetworks_Departments_DepartmentId",
                table: "LocalNetworks",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocalNetworks_Departments_DepartmentId",
                table: "LocalNetworks");

            migrationBuilder.DropIndex(
                name: "IX_LocalNetworks_DepartmentId",
                table: "LocalNetworks");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "LocalNetworks");
        }
    }
}
