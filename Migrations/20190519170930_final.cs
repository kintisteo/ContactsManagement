using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactsManagement.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone2",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone3",
                table: "Contacts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone2",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Phone3",
                table: "Contacts");
        }
    }
}
