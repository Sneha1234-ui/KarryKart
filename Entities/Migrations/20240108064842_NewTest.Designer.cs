﻿// <auto-generated />
using System;
using Entities.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entities.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240108064842_NewTest")]
    partial class NewTest
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("TaxId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.HasIndex("ParentCategoryId");

                    b.HasIndex("TaxId");

                    b.ToTable("category");
                });

            modelBuilder.Entity("Entities.Models.Discounts", b =>
                {
                    b.Property<int>("Discount_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Discount_ID"));

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("Created_By")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discount_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Discount_Percent")
                        .HasColumnType("real");

                    b.Property<string>("Discount_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("End_Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Modified_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("Modified_By")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Start_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Discount_ID");

                    b.ToTable("Discount");
                });

            modelBuilder.Entity("Entities.Models.Manufacturer", b =>
                {
                    b.Property<int>("ManufacturerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ManufacturerId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ManufacturerDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManufacturerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ManufacturerId");

                    b.ToTable("manufacturers");
                });

            modelBuilder.Entity("Entities.Models.Parent_Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Parent_Category_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ParentCategory");
                });

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("AdminComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Allowcustomerreviews")
                        .HasColumnType("bit");

                    b.Property<double>("AmountInProduct")
                        .HasColumnType("float");

                    b.Property<bool>("Automaticallyaddproductstocart")
                        .HasColumnType("bit");

                    b.Property<DateTime>("AvailableEndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("AvailableForPreOrder")
                        .HasColumnType("bit");

                    b.Property<DateTime>("AvailableStartDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("CallForPrice")
                        .HasColumnType("bit");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("Created_By")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CustomerEnterPrice")
                        .HasColumnType("bit");

                    b.Property<string>("CustomerRoles")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("DisableBuyButton")
                        .HasColumnType("bit");

                    b.Property<bool>("DisableWishListButton")
                        .HasColumnType("bit");

                    b.Property<int>("DiscountId")
                        .HasColumnType("int");

                    b.Property<string>("FullDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GTINNumber")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("LimitedToStores")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<int>("ManufacturerpartNumber")
                        .HasColumnType("int");

                    b.Property<bool>("MarkAsNew")
                        .HasColumnType("bit");

                    b.Property<double>("MaxAmount")
                        .HasColumnType("float");

                    b.Property<double>("MinAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("Modified_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("Modified_By")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("OldPrice")
                        .HasColumnType("float");

                    b.Property<DateTime>("PreOrderAvailablityStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductTags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductTemplate")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProductType")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Published")
                        .HasColumnType("bit");

                    b.Property<double>("ReferenceAmount")
                        .HasColumnType("float");

                    b.Property<string>("ReferenceUnit")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("RequiredproductIDs")
                        .HasColumnType("int");

                    b.Property<bool>("RequireotherProducts")
                        .HasColumnType("bit");

                    b.Property<string>("SKU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Showonhomepage")
                        .HasColumnType("bit");

                    b.Property<bool>("TaxExpempt")
                        .HasColumnType("bit");

                    b.Property<bool>("TelecommunicationBoardCastingAndElectronicServices")
                        .HasColumnType("bit");

                    b.Property<int>("VendorId")
                        .HasColumnType("int");

                    b.Property<bool>("VisibleIndividualy")
                        .HasColumnType("bit");

                    b.Property<bool>("pangvBasePriceEnable")
                        .HasColumnType("bit");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<double>("productCost")
                        .HasColumnType("float");

                    b.Property<string>("unitOfProduct")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DiscountId");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("VendorId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Entities.Models.Shipping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("AdditionalShippingCharges")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FreeShipping")
                        .HasColumnType("bit");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ShippingEnabled")
                        .HasColumnType("bit");

                    b.Property<bool>("Shippingseperately")
                        .HasColumnType("bit");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.Property<string>("deliveryDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Shipping");
                });

            modelBuilder.Entity("Entities.Models.Tax", b =>
                {
                    b.Property<int>("TaxId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TaxId"));

                    b.Property<double>("CGSTPercentage")
                        .HasColumnType("float");

                    b.Property<string>("Created_By")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SGSTPercentage")
                        .HasColumnType("float");

                    b.Property<string>("TaxCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.HasKey("TaxId");

                    b.ToTable("Tax");
                });

            modelBuilder.Entity("Entities.Models.Vendors", b =>
                {
                    b.Property<int>("VendorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VendorId"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Created_By")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone_number")
                        .HasColumnType("int");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Zip")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.HasKey("VendorId");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.HasOne("Entities.Models.Parent_Category", "ParentCategory")
                        .WithMany()
                        .HasForeignKey("ParentCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Tax", "tax")
                        .WithMany()
                        .HasForeignKey("TaxId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParentCategory");

                    b.Navigation("tax");
                });

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.HasOne("Entities.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Discounts", "discount")
                        .WithMany()
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Vendors", "Vendor")
                        .WithMany()
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Manufacturer");

                    b.Navigation("Vendor");

                    b.Navigation("discount");
                });
#pragma warning restore 612, 618
        }
    }
}
