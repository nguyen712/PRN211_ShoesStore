using Microsoft.EntityFrameworkCore.Migrations;

namespace PRN211_ShoesStore.Migrations
{
    public partial class ShoesStoreEnityV4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryShoes_Category_categoryId",
                table: "CategoryShoes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryShoes_Shoes_shoesId",
                table: "CategoryShoes");

            migrationBuilder.DropForeignKey(
                name: "FK_ColorSpecificallyShoes_Color_colorId",
                table: "ColorSpecificallyShoes");

            migrationBuilder.DropForeignKey(
                name: "FK_ColorSpecificallyShoes_ShoesSpecifically_specificallyShoesId",
                table: "ColorSpecificallyShoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_User_UserId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Order_OrderId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_ShoesSpecifically_specificallyShoesId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoesColor_Color_ShoesId",
                table: "ShoesColor");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoesColor_Shoes_ShoesId",
                table: "ShoesColor");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoesImage_Image_ImageId",
                table: "ShoesImage");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoesImage_Shoes_ShoesId",
                table: "ShoesImage");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoesSpecifically_Shoes_ShoesId",
                table: "ShoesSpecifically");

            migrationBuilder.DropForeignKey(
                name: "FK_SpecificallyShoesSale   _Sale_saleId",
                table: "SpecificallyShoesSale   ");

            migrationBuilder.DropForeignKey(
                name: "FK_SpecificallyShoesSale   _ShoesSpecifically_specificallyShoes",
                table: "SpecificallyShoesSale   ");

            migrationBuilder.DropForeignKey(
                name: "FK_SpecificallyShoesSize_Size_sizeId",
                table: "SpecificallyShoesSize");

            migrationBuilder.DropForeignKey(
                name: "FK_SpecificallyShoesSize_SpecificallyShoesSize_specificallyShoesId",
                table: "SpecificallyShoesSize");

            migrationBuilder.DropIndex(
                name: "IX_SpecificallyShoesSale   _specificallyShoes",
                table: "SpecificallyShoesSale   ");

            migrationBuilder.DropColumn(
                name: "specificallyShoes",
                table: "SpecificallyShoesSale   ");

            migrationBuilder.RenameColumn(
                name: "ShoesId",
                table: "ShoesSpecifically",
                newName: "shoesId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoesSpecifically_ShoesId",
                table: "ShoesSpecifically",
                newName: "IX_ShoesSpecifically_shoesId");

            migrationBuilder.RenameColumn(
                name: "ShoesId",
                table: "ShoesImage",
                newName: "shoesId");

            migrationBuilder.RenameColumn(
                name: "ImageId",
                table: "ShoesImage",
                newName: "imageId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoesImage_ShoesId",
                table: "ShoesImage",
                newName: "IX_ShoesImage_shoesId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoesImage_ImageId",
                table: "ShoesImage",
                newName: "IX_ShoesImage_imageId");

            migrationBuilder.RenameColumn(
                name: "ShoesId",
                table: "ShoesColor",
                newName: "shoesId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoesColor_ShoesId",
                table: "ShoesColor",
                newName: "IX_ShoesColor_shoesId");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "OrderDetail",
                newName: "orderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                newName: "IX_OrderDetail_orderId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Order",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_UserId",
                table: "Order",
                newName: "IX_Order_userId");

            migrationBuilder.AlterColumn<int>(
                name: "specificallyShoesId",
                table: "SpecificallyShoesSize",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "sizeId",
                table: "SpecificallyShoesSize",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "saleId",
                table: "SpecificallyShoesSale   ",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "specificallyShoesId",
                table: "SpecificallyShoesSale   ",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "shoesId",
                table: "ShoesSpecifically",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "shoesId",
                table: "ShoesImage",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "imageId",
                table: "ShoesImage",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "shoesId",
                table: "ShoesColor",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "colorId",
                table: "ShoesColor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "specificallyShoesId",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "orderId",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "userId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "specificallyShoesId",
                table: "ColorSpecificallyShoes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "colorId",
                table: "ColorSpecificallyShoes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "shoesId",
                table: "CategoryShoes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "categoryId",
                table: "CategoryShoes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SpecificallyShoesSale   _specificallyShoesId",
                table: "SpecificallyShoesSale   ",
                column: "specificallyShoesId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoesColor_colorId",
                table: "ShoesColor",
                column: "colorId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryShoes_Category_categoryId",
                table: "CategoryShoes",
                column: "categoryId",
                principalTable: "Category",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryShoes_Shoes_shoesId",
                table: "CategoryShoes",
                column: "shoesId",
                principalTable: "Shoes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ColorSpecificallyShoes_Color_colorId",
                table: "ColorSpecificallyShoes",
                column: "colorId",
                principalTable: "Color",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ColorSpecificallyShoes_ShoesSpecifically_specificallyShoesId",
                table: "ColorSpecificallyShoes",
                column: "specificallyShoesId",
                principalTable: "ShoesSpecifically",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_User_userId",
                table: "Order",
                column: "userId",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Order_orderId",
                table: "OrderDetail",
                column: "orderId",
                principalTable: "Order",
                principalColumn: "orderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_ShoesSpecifically_specificallyShoesId",
                table: "OrderDetail",
                column: "specificallyShoesId",
                principalTable: "ShoesSpecifically",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoesColor_Color_colorId",
                table: "ShoesColor",
                column: "colorId",
                principalTable: "Color",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoesColor_Shoes_shoesId",
                table: "ShoesColor",
                column: "shoesId",
                principalTable: "Shoes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoesImage_Image_imageId",
                table: "ShoesImage",
                column: "imageId",
                principalTable: "Image",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoesImage_Shoes_shoesId",
                table: "ShoesImage",
                column: "shoesId",
                principalTable: "Shoes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoesSpecifically_Shoes_shoesId",
                table: "ShoesSpecifically",
                column: "shoesId",
                principalTable: "Shoes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SpecificallyShoesSale   _Sale_saleId",
                table: "SpecificallyShoesSale   ",
                column: "saleId",
                principalTable: "Sale",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SpecificallyShoesSale   _ShoesSpecifically_specificallyShoesId",
                table: "SpecificallyShoesSale   ",
                column: "specificallyShoesId",
                principalTable: "ShoesSpecifically",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SpecificallyShoesSize_ShoesSpecifically_specificallyShoesId",
                table: "SpecificallyShoesSize",
                column: "specificallyShoesId",
                principalTable: "ShoesSpecifically",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SpecificallyShoesSize_Size_sizeId",
                table: "SpecificallyShoesSize",
                column: "sizeId",
                principalTable: "Size",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryShoes_Category_categoryId",
                table: "CategoryShoes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryShoes_Shoes_shoesId",
                table: "CategoryShoes");

            migrationBuilder.DropForeignKey(
                name: "FK_ColorSpecificallyShoes_Color_colorId",
                table: "ColorSpecificallyShoes");

            migrationBuilder.DropForeignKey(
                name: "FK_ColorSpecificallyShoes_ShoesSpecifically_specificallyShoesId",
                table: "ColorSpecificallyShoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_User_userId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Order_orderId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_ShoesSpecifically_specificallyShoesId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoesColor_Color_colorId",
                table: "ShoesColor");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoesColor_Shoes_shoesId",
                table: "ShoesColor");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoesImage_Image_imageId",
                table: "ShoesImage");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoesImage_Shoes_shoesId",
                table: "ShoesImage");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoesSpecifically_Shoes_shoesId",
                table: "ShoesSpecifically");

            migrationBuilder.DropForeignKey(
                name: "FK_SpecificallyShoesSale   _Sale_saleId",
                table: "SpecificallyShoesSale   ");

            migrationBuilder.DropForeignKey(
                name: "FK_SpecificallyShoesSale   _ShoesSpecifically_specificallyShoesId",
                table: "SpecificallyShoesSale   ");

            migrationBuilder.DropForeignKey(
                name: "FK_SpecificallyShoesSize_ShoesSpecifically_specificallyShoesId",
                table: "SpecificallyShoesSize");

            migrationBuilder.DropForeignKey(
                name: "FK_SpecificallyShoesSize_Size_sizeId",
                table: "SpecificallyShoesSize");

            migrationBuilder.DropIndex(
                name: "IX_SpecificallyShoesSale   _specificallyShoesId",
                table: "SpecificallyShoesSale   ");

            migrationBuilder.DropIndex(
                name: "IX_ShoesColor_colorId",
                table: "ShoesColor");

            migrationBuilder.DropColumn(
                name: "specificallyShoesId",
                table: "SpecificallyShoesSale   ");

            migrationBuilder.DropColumn(
                name: "colorId",
                table: "ShoesColor");

            migrationBuilder.RenameColumn(
                name: "shoesId",
                table: "ShoesSpecifically",
                newName: "ShoesId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoesSpecifically_shoesId",
                table: "ShoesSpecifically",
                newName: "IX_ShoesSpecifically_ShoesId");

            migrationBuilder.RenameColumn(
                name: "shoesId",
                table: "ShoesImage",
                newName: "ShoesId");

            migrationBuilder.RenameColumn(
                name: "imageId",
                table: "ShoesImage",
                newName: "ImageId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoesImage_shoesId",
                table: "ShoesImage",
                newName: "IX_ShoesImage_ShoesId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoesImage_imageId",
                table: "ShoesImage",
                newName: "IX_ShoesImage_ImageId");

            migrationBuilder.RenameColumn(
                name: "shoesId",
                table: "ShoesColor",
                newName: "ShoesId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoesColor_shoesId",
                table: "ShoesColor",
                newName: "IX_ShoesColor_ShoesId");

            migrationBuilder.RenameColumn(
                name: "orderId",
                table: "OrderDetail",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_orderId",
                table: "OrderDetail",
                newName: "IX_OrderDetail_OrderId");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Order",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_userId",
                table: "Order",
                newName: "IX_Order_UserId");

            migrationBuilder.AlterColumn<int>(
                name: "specificallyShoesId",
                table: "SpecificallyShoesSize",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "sizeId",
                table: "SpecificallyShoesSize",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "saleId",
                table: "SpecificallyShoesSale   ",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "specificallyShoes",
                table: "SpecificallyShoesSale   ",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ShoesId",
                table: "ShoesSpecifically",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ShoesId",
                table: "ShoesImage",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ImageId",
                table: "ShoesImage",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ShoesId",
                table: "ShoesColor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "specificallyShoesId",
                table: "OrderDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "OrderDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Order",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "specificallyShoesId",
                table: "ColorSpecificallyShoes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "colorId",
                table: "ColorSpecificallyShoes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "shoesId",
                table: "CategoryShoes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "categoryId",
                table: "CategoryShoes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_SpecificallyShoesSale   _specificallyShoes",
                table: "SpecificallyShoesSale   ",
                column: "specificallyShoes");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryShoes_Category_categoryId",
                table: "CategoryShoes",
                column: "categoryId",
                principalTable: "Category",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryShoes_Shoes_shoesId",
                table: "CategoryShoes",
                column: "shoesId",
                principalTable: "Shoes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ColorSpecificallyShoes_Color_colorId",
                table: "ColorSpecificallyShoes",
                column: "colorId",
                principalTable: "Color",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ColorSpecificallyShoes_ShoesSpecifically_specificallyShoesId",
                table: "ColorSpecificallyShoes",
                column: "specificallyShoesId",
                principalTable: "ShoesSpecifically",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_User_UserId",
                table: "Order",
                column: "UserId",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Order_OrderId",
                table: "OrderDetail",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "orderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_ShoesSpecifically_specificallyShoesId",
                table: "OrderDetail",
                column: "specificallyShoesId",
                principalTable: "ShoesSpecifically",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoesColor_Color_ShoesId",
                table: "ShoesColor",
                column: "ShoesId",
                principalTable: "Color",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoesColor_Shoes_ShoesId",
                table: "ShoesColor",
                column: "ShoesId",
                principalTable: "Shoes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoesImage_Image_ImageId",
                table: "ShoesImage",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoesImage_Shoes_ShoesId",
                table: "ShoesImage",
                column: "ShoesId",
                principalTable: "Shoes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoesSpecifically_Shoes_ShoesId",
                table: "ShoesSpecifically",
                column: "ShoesId",
                principalTable: "Shoes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SpecificallyShoesSale   _Sale_saleId",
                table: "SpecificallyShoesSale   ",
                column: "saleId",
                principalTable: "Sale",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SpecificallyShoesSale   _ShoesSpecifically_specificallyShoes",
                table: "SpecificallyShoesSale   ",
                column: "specificallyShoes",
                principalTable: "ShoesSpecifically",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SpecificallyShoesSize_Size_sizeId",
                table: "SpecificallyShoesSize",
                column: "sizeId",
                principalTable: "Size",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SpecificallyShoesSize_SpecificallyShoesSize_specificallyShoesId",
                table: "SpecificallyShoesSize",
                column: "specificallyShoesId",
                principalTable: "SpecificallyShoesSize",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
