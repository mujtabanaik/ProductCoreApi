using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductCoreApi.Migrations
{
    public partial class Altertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "discount",
                schema: "dbo",
                table: "Product",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "discount",
                schema: "dbo",
                table: "Product");
        }
    }
}
