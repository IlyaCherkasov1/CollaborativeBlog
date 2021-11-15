using Microsoft.EntityFrameworkCore.Migrations;

namespace CollaborativeBlog.Migrations
{
    public partial class ImageUri : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageName",
                table: "Image",
                newName: "ImageUri");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUri",
                table: "Image",
                newName: "ImageName");
        }
    }
}
