using Microsoft.EntityFrameworkCore.Migrations;

namespace PRN211_ShoesStore.Migrations
{
    public partial class addImageToShoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "price",
                table: "Shoes",
                type: "decimal(18,4)",
                precision: 18,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<decimal>(
                name: "price",
                table: "Shoes",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldPrecision: 18,
                oldScale: 4);
        }
    }
}
