using Microsoft.EntityFrameworkCore.Migrations;

namespace CollaborativeBlog.Migrations
{
    public partial class AddUserRaitingInPostTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "UserRating",
                table: "Posts",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserRating",
                table: "Posts");
        }
    }
}
