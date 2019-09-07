using Microsoft.EntityFrameworkCore.Migrations;

namespace FleetControl.WebUI.Migrations
{
    public partial class AddIdentity5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExternalCardId",
                table: "Card",
                newName: "Externalfd");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Externalfd",
                table: "Card",
                newName: "ExternalCardId");
        }
    }
}
