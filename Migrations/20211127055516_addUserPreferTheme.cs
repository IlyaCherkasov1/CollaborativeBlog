using Microsoft.EntityFrameworkCore.Migrations;

namespace CollaborativeBlog.Migrations
{
    public partial class addUserPreferTheme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDarkTheme",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDarkTheme",
                table: "AspNetUsers");
        }
    }
}
