using Microsoft.EntityFrameworkCore.Migrations;

namespace SweetShop.Migrations
{
    public partial class PriceProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SuggestedPairing",
                table: "Flavors");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Treats",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Treats");

            migrationBuilder.AddColumn<string>(
                name: "SuggestedPairing",
                table: "Flavors",
                nullable: true);
        }
    }
}
