using Microsoft.EntityFrameworkCore.Migrations;

namespace Checkboxselectlistradiobutton.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Living",
                table: "Players",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Living",
                table: "Players");
        }
    }
}
