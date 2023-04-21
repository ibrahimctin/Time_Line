using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Time_Line.Infrastructure.Migrations
{
    public partial class post_comment_navigation_prop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CommentId",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentId",
                table: "Posts");
        }
    }
}
