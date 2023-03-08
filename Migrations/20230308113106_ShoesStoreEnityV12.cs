using Microsoft.EntityFrameworkCore.Migrations;

namespace PRN211_ShoesStore.Migrations
{
    public partial class ShoesStoreEnityV12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image",
                table: "CartItems");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "CartItems",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
