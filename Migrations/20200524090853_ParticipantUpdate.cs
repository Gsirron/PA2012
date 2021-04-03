using Microsoft.EntityFrameworkCore.Migrations;

namespace Prototype.Migrations
{
    public partial class ParticipantUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Participate_Phase",
                table: "SiteData");

            migrationBuilder.DropColumn(
                name: "Survey_ID",
                table: "SiteData");

            migrationBuilder.DropColumn(
                name: "Website_Link",
                table: "SiteData");

            migrationBuilder.DropColumn(
                name: "Participant_Data",
                table: "Participant");

            migrationBuilder.AddColumn<bool>(
                name: "SiteData_Active",
                table: "SiteData",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SiteData_Link",
                table: "SiteData",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SiteData_Name",
                table: "SiteData",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Participant_ResponseId",
                table: "Participant",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SiteData_Active",
                table: "SiteData");

            migrationBuilder.DropColumn(
                name: "SiteData_Link",
                table: "SiteData");

            migrationBuilder.DropColumn(
                name: "SiteData_Name",
                table: "SiteData");

            migrationBuilder.DropColumn(
                name: "Participant_ResponseId",
                table: "Participant");

            migrationBuilder.AddColumn<int>(
                name: "Participate_Phase",
                table: "SiteData",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Survey_ID",
                table: "SiteData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Website_Link",
                table: "SiteData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Participant_Data",
                table: "Participant",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
