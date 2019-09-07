using Microsoft.EntityFrameworkCore.Migrations;

namespace FleetControl.WebUI.Migrations
{
    public partial class AddIdentity6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Externalfd",
                table: "Card",
                newName: "ExternalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExternalId",
                table: "Card",
                newName: "Externalfd");
        }
    }
}
