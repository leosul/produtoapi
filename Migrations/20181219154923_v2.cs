using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductCatalog.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quatity",
                table: "Product",
                newName: "Quantity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Product",
                newName: "Quatity");
        }
    }
}
