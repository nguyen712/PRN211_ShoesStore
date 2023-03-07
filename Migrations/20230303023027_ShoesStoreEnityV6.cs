using Microsoft.EntityFrameworkCore.Migrations;

namespace PRN211_ShoesStore.Migrations
{
    public partial class ShoesStoreEnityV6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "Size",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "ShoesSpecifically",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "ShoesImage",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "ShoesColor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "Shoes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "Sale",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "Role",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "Order",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "Image",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "ColorSpecificallyShoes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "Color",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "CategoryShoes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "Category",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "User");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Size");

            migrationBuilder.DropColumn(
                name: "status",
                table: "ShoesSpecifically");

            migrationBuilder.DropColumn(
                name: "status",
                table: "ShoesImage");

            migrationBuilder.DropColumn(
                name: "status",
                table: "ShoesColor");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "status",
                table: "ColorSpecificallyShoes");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Color");

            migrationBuilder.DropColumn(
                name: "status",
                table: "CategoryShoes");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Category");
        }
    }
}
