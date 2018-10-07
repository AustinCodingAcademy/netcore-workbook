using Microsoft.EntityFrameworkCore.Migrations;

namespace Spa2.Migrations
{
    public partial class ServNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "ServiceProviders",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "ServiceProviders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "ServiceProviders");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "ServiceProviders",
                newName: "FullName");
        }
    }
}
