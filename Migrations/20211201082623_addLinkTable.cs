using Microsoft.EntityFrameworkCore.Migrations;

namespace CollaborativeBlog.Migrations
{
    public partial class addLinkTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    LinkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.LinkId);
                });

            migrationBuilder.CreateTable(
                name: "LinkPost",
                columns: table => new
                {
                    LinksLinkId = table.Column<int>(type: "int", nullable: false),
                    PostsPostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkPost", x => new { x.LinksLinkId, x.PostsPostId });
                    table.ForeignKey(
                        name: "FK_LinkPost_Links_LinksLinkId",
                        column: x => x.LinksLinkId,
                        principalTable: "Links",
                        principalColumn: "LinkId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LinkPost_Posts_PostsPostId",
                        column: x => x.PostsPostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LinkPost_PostsPostId",
                table: "LinkPost",
                column: "PostsPostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LinkPost");

            migrationBuilder.DropTable(
                name: "Links");
        }
    }
}
