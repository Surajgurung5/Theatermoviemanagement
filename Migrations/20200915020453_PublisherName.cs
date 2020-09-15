using Microsoft.EntityFrameworkCore.Migrations;

namespace Theatermoviemanagement.Migrations
{
    public partial class PublisherName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PublisherTitle",
                table: "Movies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublisherTitle",
                table: "Movies");
        }
    }
}
