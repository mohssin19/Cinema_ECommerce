using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema_ECommerce.Migrations
{
    public partial class Rename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "price",
                table: "Movies",
                newName: "Price");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Movies",
                newName: "price");
        }
    }
}
