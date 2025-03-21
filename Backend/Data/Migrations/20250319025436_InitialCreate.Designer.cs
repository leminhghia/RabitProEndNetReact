﻿// <auto-generated />
using System;
using Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend.Data.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20250319025436_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.3");

            modelBuilder.Entity("Backend.Models.AgeGroup", b =>
                {
                    b.Property<int>("AgeGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("CreateBy")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxWeight")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MinWeight")
                        .HasColumnType("INTEGER");

                    b.HasKey("AgeGroupId");

                    b.ToTable("AgeGroup", (string)null);
                });

            modelBuilder.Entity("Backend.Models.Brand", b =>
                {
                    b.Property<int>("BraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("CreateBy")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BraId");

                    b.ToTable("Brand", (string)null);
                });

            modelBuilder.Entity("Backend.Models.Category", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("CreateBy")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CatId");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("Backend.Models.Color", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ColorId");

                    b.ToTable("Color", (string)null);
                });

            modelBuilder.Entity("Backend.Models.Price", b =>
                {
                    b.Property<int>("PriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("DiscountPrice")
                        .HasColumnType("INTEGER");

                    b.Property<long>("PriceValue")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProColorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PriId");

                    b.HasIndex("ProColorId");

                    b.ToTable("Price", (string)null);
                });

            modelBuilder.Entity("Backend.Models.Product", b =>
                {
                    b.Property<int>("ProId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BraId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CatId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ProId");

                    b.HasIndex("BraId");

                    b.HasIndex("CatId");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("Backend.Models.ProductColor", b =>
                {
                    b.Property<int>("ProColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ColorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProImgId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProColorId");

                    b.HasIndex("ColorId");

                    b.HasIndex("ProId");

                    b.HasIndex("ProImgId");

                    b.ToTable("ProductColor", (string)null);
                });

            modelBuilder.Entity("Backend.Models.ProductImages", b =>
                {
                    b.Property<int>("ProImgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("ProImgId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Backend.Models.ProductSize", b =>
                {
                    b.Property<int>("ProSizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AgeGroupId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SizeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProSizeId");

                    b.HasIndex("AgeGroupId");

                    b.HasIndex("ProId");

                    b.HasIndex("SizeId");

                    b.ToTable("ProductSize", (string)null);
                });

            modelBuilder.Entity("Backend.Models.Size", b =>
                {
                    b.Property<int>("SizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SizeId");

                    b.ToTable("Size", (string)null);
                });

            modelBuilder.Entity("Backend.Models.Price", b =>
                {
                    b.HasOne("Backend.Models.ProductColor", "ProductColor")
                        .WithMany("Prices")
                        .HasForeignKey("ProColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductColor");
                });

            modelBuilder.Entity("Backend.Models.Product", b =>
                {
                    b.HasOne("Backend.Models.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Backend.Models.ProductColor", b =>
                {
                    b.HasOne("Backend.Models.Color", "Color")
                        .WithMany("ProductColors")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Models.Product", "Product")
                        .WithMany("ProductColors")
                        .HasForeignKey("ProId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Models.ProductImages", "Images")
                        .WithMany()
                        .HasForeignKey("ProImgId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("Images");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Backend.Models.ProductSize", b =>
                {
                    b.HasOne("Backend.Models.AgeGroup", "AgeGroup")
                        .WithMany("ProductSizes")
                        .HasForeignKey("AgeGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Models.Product", "Product")
                        .WithMany("ProductSizes")
                        .HasForeignKey("ProId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Models.Size", "Size")
                        .WithMany("ProductSizes")
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AgeGroup");

                    b.Navigation("Product");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("Backend.Models.AgeGroup", b =>
                {
                    b.Navigation("ProductSizes");
                });

            modelBuilder.Entity("Backend.Models.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Backend.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Backend.Models.Color", b =>
                {
                    b.Navigation("ProductColors");
                });

            modelBuilder.Entity("Backend.Models.Product", b =>
                {
                    b.Navigation("ProductColors");

                    b.Navigation("ProductSizes");
                });

            modelBuilder.Entity("Backend.Models.ProductColor", b =>
                {
                    b.Navigation("Prices");
                });

            modelBuilder.Entity("Backend.Models.Size", b =>
                {
                    b.Navigation("ProductSizes");
                });
#pragma warning restore 612, 618
        }
    }
}
