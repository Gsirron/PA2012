using Microsoft.EntityFrameworkCore.Migrations;

namespace Prototype.Migrations
{
    public partial class sitedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Participant_Age",
                table: "Participant",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Participant_Gender",
                table: "Participant",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Participant_Group",
                table: "Participant",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Participant_Phase",
                table: "Participant",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SiteData",
                columns: table => new
                {
                    SiteDataId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Website_Link = table.Column<string>(nullable: true),
                    Participate_Phase = table.Column<int>(nullable: false),
                    Survey_ID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteData", x => x.SiteDataId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SiteData");

            migrationBuilder.DropColumn(
                name: "Participant_Age",
                table: "Participant");

            migrationBuilder.DropColumn(
                name: "Participant_Gender",
                table: "Participant");

            migrationBuilder.DropColumn(
                name: "Participant_Group",
                table: "Participant");

            migrationBuilder.DropColumn(
                name: "Participant_Phase",
                table: "Participant");
        }
    }
}
