using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreBlog.DataAccess.Migrations
{
    public partial class CommentContentAddToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CommentContent",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentContent",
                table: "Comments");
        }
    }
}
