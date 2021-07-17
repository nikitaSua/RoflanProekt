using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class skillEntChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "sch",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                schema: "sch",
                table: "Skills");
        }
    }
}
