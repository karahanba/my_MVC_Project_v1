using Microsoft.EntityFrameworkCore.Migrations;

namespace my_MVC_Project_v1.Migrations
{
    public partial class contactextras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Instagram",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Linkedin",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Privacy",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Twitter",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "About",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "Instagram",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "Linkedin",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "Privacy",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "Twitter",
                table: "Contact");
        }
    }
}
