using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductCoreApi.Migrations
{
    public partial class Changeddatatypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "nrc",
                schema: "dbo",
                table: "Product",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "mrc",
                schema: "dbo",
                table: "Product",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "discount",
                schema: "dbo",
                table: "Product",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "nrc",
                schema: "dbo",
                table: "Product",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<string>(
                name: "mrc",
                schema: "dbo",
                table: "Product",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<string>(
                name: "discount",
                schema: "dbo",
                table: "Product",
                nullable: true,
                oldClrType: typeof(float));
        }
    }
}
