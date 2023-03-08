using Microsoft.EntityFrameworkCore.Migrations;

namespace PRN211_ShoesStore.Migrations
{
    public partial class ShoesStoreEnityV11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShoesImg",
                table: "CartItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "CartItems",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShoesImg",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "image",
                table: "CartItems");
        }
    }
}
