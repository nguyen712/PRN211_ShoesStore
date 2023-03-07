using Microsoft.EntityFrameworkCore.Migrations;

namespace PRN211_ShoesStore.Migrations
{
    public partial class changeImageToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_Image_imageid",
                table: "Shoes");

            migrationBuilder.DropIndex(
                name: "IX_Shoes_imageid",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "imageid",
                table: "Shoes");

            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "Shoes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image",
                table: "Shoes");

            migrationBuilder.AddColumn<int>(
                name: "imageid",
                table: "Shoes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shoes_imageid",
                table: "Shoes",
                column: "imageid");

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_Image_imageid",
                table: "Shoes",
                column: "imageid",
                principalTable: "Image",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
