using Microsoft.EntityFrameworkCore.Migrations;

namespace CollaborativeBlog.Migrations
{
    public partial class ChangeLikeTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LikesPost");

            migrationBuilder.DropTable(
                name: "LikesUser");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.CreateTable(
                name: "Like",
                columns: table => new
                {
                    LikeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Like", x => x.LikeId);
                });

            migrationBuilder.CreateTable(
                name: "LikePost",
                columns: table => new
                {
                    LikesLikeId = table.Column<int>(type: "int", nullable: false),
                    PostsPostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikePost", x => new { x.LikesLikeId, x.PostsPostId });
                    table.ForeignKey(
                        name: "FK_LikePost_Like_LikesLikeId",
                        column: x => x.LikesLikeId,
                        principalTable: "Like",
                        principalColumn: "LikeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LikePost_Posts_PostsPostId",
                        column: x => x.PostsPostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LikeUser",
                columns: table => new
                {
                    LikesLikeId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeUser", x => new { x.LikesLikeId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_LikeUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LikeUser_Like_LikesLikeId",
                        column: x => x.LikesLikeId,
                        principalTable: "Like",
                        principalColumn: "LikeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LikePost_PostsPostId",
                table: "LikePost",
                column: "PostsPostId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeUser_UsersId",
                table: "LikeUser",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LikePost");

            migrationBuilder.DropTable(
                name: "LikeUser");

            migrationBuilder.DropTable(
                name: "Like");

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    LikesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.LikesId);
                });

            migrationBuilder.CreateTable(
                name: "LikesPost",
                columns: table => new
                {
                    LikesId = table.Column<int>(type: "int", nullable: false),
                    PostsPostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikesPost", x => new { x.LikesId, x.PostsPostId });
                    table.ForeignKey(
                        name: "FK_LikesPost_Likes_LikesId",
                        column: x => x.LikesId,
                        principalTable: "Likes",
                        principalColumn: "LikesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LikesPost_Posts_PostsPostId",
                        column: x => x.PostsPostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LikesUser",
                columns: table => new
                {
                    LikesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikesUser", x => new { x.LikesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_LikesUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LikesUser_Likes_LikesId",
                        column: x => x.LikesId,
                        principalTable: "Likes",
                        principalColumn: "LikesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LikesPost_PostsPostId",
                table: "LikesPost",
                column: "PostsPostId");

            migrationBuilder.CreateIndex(
                name: "IX_LikesUser_UsersId",
                table: "LikesUser",
                column: "UsersId");
        }
    }
}
