using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactsManagement.Migrations
{
    public partial class addContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 200, nullable: false), //FirstName is required
                    LastName = table.Column<string>(maxLength: 200, nullable: false), //LastName is required
                    Email = table.Column<string>(maxLength: 200, nullable: false), //email is required
                    Address = table.Column<string>(nullable: true) //address is optional so its nullable
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId); //here is the primary key which is ContactId
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
