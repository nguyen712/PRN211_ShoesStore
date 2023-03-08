﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PRN211_ShoesStore.Models;

namespace PRN211_ShoesStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230308113106_ShoesStoreEnityV12")]
    partial class ShoesStoreEnityV12
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("ShoesImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpecificallyShoesId")
                        .HasColumnType("int");

                    b.Property<string>("SpecificallyShoesnName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.CategoryShoes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("categoryId")
                        .HasColumnType("int");

                    b.Property<int>("shoesId")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("categoryId");

                    b.HasIndex("shoesId");

                    b.ToTable("CategoryShoes");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("createBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<string>("updateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("updateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Color");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.ColorSpecificallyShoes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("colorId")
                        .HasColumnType("int");

                    b.Property<int>("specificallyShoesId")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("colorId");

                    b.HasIndex("specificallyShoesId");

                    b.ToTable("ColorSpecificallyShoes");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.Image", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("createBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("image")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime?>("lastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<string>("updateBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.Order", b =>
                {
                    b.Property<int>("orderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("price")
                        .HasColumnType("Money");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("orderId");

                    b.HasIndex("userId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.OrderDetail", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("orderId")
                        .HasColumnType("int");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<long>("quantity")
                        .HasColumnType("bigint");

                    b.Property<int>("specificallyShoesId")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("orderId");

                    b.HasIndex("specificallyShoesId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.Role", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("creatDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("roleDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("roleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("updateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.Sale", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("discount")
                        .HasColumnType("float");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.Shoes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("launchDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasPrecision(18, 4)
                        .HasColumnType("decimal(18,4)");

                    b.Property<long>("quantity")
                        .HasColumnType("bigint");

                    b.Property<string>("shoesDetails")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("Shoes");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.ShoesColor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("colorId")
                        .HasColumnType("int");

                    b.Property<int>("shoesId")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("colorId");

                    b.HasIndex("shoesId");

                    b.ToTable("ShoesColor");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.ShoesImage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("imageId")
                        .HasColumnType("int");

                    b.Property<int>("shoesId")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("imageId");

                    b.HasIndex("shoesId");

                    b.ToTable("ShoesImage");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.Size", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("sizeNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("Size");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.SpecificallyShoes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("Money");

                    b.Property<long>("quantity")
                        .HasColumnType("bigint");

                    b.Property<int>("shoesId")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("updateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("shoesId");

                    b.ToTable("ShoesSpecifically");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.SpecificallyShoesSale", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("saleId")
                        .HasColumnType("int");

                    b.Property<int>("specificallyShoesId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("saleId");

                    b.HasIndex("specificallyShoesId");

                    b.ToTable("SpecificallyShoesSale   ");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.SpecificallyShoesSize", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("sizeId")
                        .HasColumnType("int");

                    b.Property<int>("specificallyShoesId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("sizeId");

                    b.HasIndex("specificallyShoesId");

                    b.ToTable("SpecificallyShoesSize");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("roleId")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("updateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("roleId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.CategoryShoes", b =>
                {
                    b.HasOne("PRN211_ShoesStore.Models.Entity.Category", "category")
                        .WithMany()
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PRN211_ShoesStore.Models.Entity.Shoes", "shoes")
                        .WithMany()
                        .HasForeignKey("shoesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");

                    b.Navigation("shoes");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.ColorSpecificallyShoes", b =>
                {
                    b.HasOne("PRN211_ShoesStore.Models.Entity.Color", "color")
                        .WithMany()
                        .HasForeignKey("colorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PRN211_ShoesStore.Models.Entity.SpecificallyShoes", "shoes")
                        .WithMany()
                        .HasForeignKey("specificallyShoesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("color");

                    b.Navigation("shoes");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.Order", b =>
                {
                    b.HasOne("PRN211_ShoesStore.Models.Entity.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.OrderDetail", b =>
                {
                    b.HasOne("PRN211_ShoesStore.Models.Entity.Order", "order")
                        .WithMany()
                        .HasForeignKey("orderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PRN211_ShoesStore.Models.Entity.SpecificallyShoes", "shoes")
                        .WithMany()
                        .HasForeignKey("specificallyShoesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("order");

                    b.Navigation("shoes");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.ShoesColor", b =>
                {
                    b.HasOne("PRN211_ShoesStore.Models.Entity.Color", "color")
                        .WithMany()
                        .HasForeignKey("colorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PRN211_ShoesStore.Models.Entity.Shoes", "shoes")
                        .WithMany()
                        .HasForeignKey("shoesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("color");

                    b.Navigation("shoes");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.ShoesImage", b =>
                {
                    b.HasOne("PRN211_ShoesStore.Models.Entity.Image", "image")
                        .WithMany()
                        .HasForeignKey("imageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PRN211_ShoesStore.Models.Entity.Shoes", "shoes")
                        .WithMany()
                        .HasForeignKey("shoesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("image");

                    b.Navigation("shoes");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.SpecificallyShoes", b =>
                {
                    b.HasOne("PRN211_ShoesStore.Models.Entity.Shoes", "shoes")
                        .WithMany()
                        .HasForeignKey("shoesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("shoes");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.SpecificallyShoesSale", b =>
                {
                    b.HasOne("PRN211_ShoesStore.Models.Entity.Sale", "sale")
                        .WithMany()
                        .HasForeignKey("saleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PRN211_ShoesStore.Models.Entity.SpecificallyShoes", "shoes")
                        .WithMany()
                        .HasForeignKey("specificallyShoesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("sale");

                    b.Navigation("shoes");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.SpecificallyShoesSize", b =>
                {
                    b.HasOne("PRN211_ShoesStore.Models.Entity.Size", "size")
                        .WithMany()
                        .HasForeignKey("sizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PRN211_ShoesStore.Models.Entity.SpecificallyShoes", "shoes")
                        .WithMany()
                        .HasForeignKey("specificallyShoesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("shoes");

                    b.Navigation("size");
                });

            modelBuilder.Entity("PRN211_ShoesStore.Models.Entity.User", b =>
                {
                    b.HasOne("PRN211_ShoesStore.Models.Entity.Role", "role")
                        .WithMany()
                        .HasForeignKey("roleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("role");
                });
#pragma warning restore 612, 618
        }
    }
}