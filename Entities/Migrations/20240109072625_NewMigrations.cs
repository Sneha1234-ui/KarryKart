using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class NewMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Discount",
                columns: table => new
                {
                    Discount_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discount_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discount_Percent = table.Column<float>(type: "real", nullable: false),
                    Discount_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discount", x => x.Discount_ID);
                });

            migrationBuilder.CreateTable(
                name: "DownloadProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsedownloadURL = table.Column<bool>(type: "bit", nullable: false),
                    DownloadURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unlimiteddownloads = table.Column<bool>(type: "bit", nullable: false),
                    NoofDays = table.Column<int>(type: "int", nullable: false),
                    Downloadactivationtype = table.Column<int>(type: "int", nullable: false),
                    Hasuseragreement = table.Column<bool>(type: "bit", nullable: false),
                    Hassampledownloadfile = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownloadProduct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GiftCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Giftcard = table.Column<bool>(type: "bit", nullable: false),
                    giftcardtype = table.Column<int>(type: "int", nullable: false),
                    Overriddengiftcardamount = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiftCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    inventoryMethodEnum = table.Column<int>(type: "int", nullable: false),
                    Stockquantity = table.Column<int>(type: "int", nullable: false),
                    warehouse = table.Column<int>(type: "int", nullable: false),
                    MultipleWarehouse = table.Column<bool>(type: "bit", nullable: false),
                    Displayavailability = table.Column<bool>(type: "bit", nullable: false),
                    Minimumstockqty = table.Column<int>(type: "int", nullable: false),
                    lowstockactivityenum = table.Column<int>(type: "int", nullable: false),
                    Notifyforqtybelow = table.Column<int>(type: "int", nullable: false),
                    backordersbelow = table.Column<int>(type: "int", nullable: false),
                    Allowbackinstocksubscriptions = table.Column<bool>(type: "bit", nullable: false),
                    productavailabilityrange = table.Column<int>(type: "int", nullable: false),
                    Allowonlyexistingattributecombinations = table.Column<bool>(type: "bit", nullable: false),
                    Minimumcartqty = table.Column<int>(type: "int", nullable: false),
                    Maximumcartqty = table.Column<int>(type: "int", nullable: false),
                    Allowedquantities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notreturnable = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "manufacturers",
                columns: table => new
                {
                    ManufacturerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManufacturerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manufacturers", x => x.ManufacturerId);
                });

            migrationBuilder.CreateTable(
                name: "ParentCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Parent_Category_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentCategory = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecurringProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cycle_Length = table.Column<int>(type: "int", nullable: false),
                    Period = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Total_Cycle = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecurringProduct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rental",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsRental = table.Column<bool>(type: "bit", nullable: false),
                    RentalPeriodLength = table.Column<int>(type: "int", nullable: false),
                    RentalPeriod = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rental", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SEO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    searchenginefriendlypagename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SEO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shipping",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShippingEnabled = table.Column<bool>(type: "bit", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    FreeShipping = table.Column<bool>(type: "bit", nullable: false),
                    Shippingseperately = table.Column<bool>(type: "bit", nullable: false),
                    AdditionalShippingCharges = table.Column<double>(type: "float", nullable: false),
                    deliveryDate = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipping", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tax",
                columns: table => new
                {
                    TaxId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SGSTPercentage = table.Column<double>(type: "float", nullable: false),
                    CGSTPercentage = table.Column<double>(type: "float", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tax", x => x.TaxId);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    VendorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<int>(type: "int", nullable: false),
                    Phone_number = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.VendorId);
                });

            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentCategoryId = table.Column<int>(type: "int", nullable: false),
                    TaxId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_category_ParentCategory_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "ParentCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_category_Tax_TaxId",
                        column: x => x.TaxId,
                        principalTable: "Tax",
                        principalColumn: "TaxId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    price = table.Column<double>(type: "float", nullable: false),
                    OldPrice = table.Column<double>(type: "float", nullable: false),
                    productCost = table.Column<double>(type: "float", nullable: false),
                    DisableBuyButton = table.Column<bool>(type: "bit", nullable: false),
                    DisableWishListButton = table.Column<bool>(type: "bit", nullable: false),
                    AvailableForPreOrder = table.Column<bool>(type: "bit", nullable: false),
                    PreOrderAvailablityStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CallForPrice = table.Column<bool>(type: "bit", nullable: false),
                    CustomerEnterPrice = table.Column<bool>(type: "bit", nullable: false),
                    MinAmount = table.Column<double>(type: "float", nullable: false),
                    MaxAmount = table.Column<double>(type: "float", nullable: false),
                    pangvBasePriceEnable = table.Column<bool>(type: "bit", nullable: false),
                    AmountInProduct = table.Column<double>(type: "float", nullable: false),
                    unitOfProduct = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ReferenceAmount = table.Column<double>(type: "float", nullable: false),
                    ReferenceUnit = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DiscountId = table.Column<int>(type: "int", nullable: false),
                    TaxExpempt = table.Column<bool>(type: "bit", nullable: false),
                    TelecommunicationBoardCastingAndElectronicServices = table.Column<bool>(type: "bit", nullable: false),
                    VendorId = table.Column<int>(type: "int", nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SKU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false),
                    GiftCardId = table.Column<int>(type: "int", nullable: false),
                    Recurring_ProductId = table.Column<int>(type: "int", nullable: false),
                    RentalId = table.Column<int>(type: "int", nullable: false),
                    SeoId = table.Column<int>(type: "int", nullable: false),
                    DownloadableProductId = table.Column<int>(type: "int", nullable: false),
                    ShippingId = table.Column<int>(type: "int", nullable: false),
                    InventoryId = table.Column<int>(type: "int", nullable: false),
                    Published = table.Column<bool>(type: "bit", nullable: false),
                    ProductTags = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GTINNumber = table.Column<int>(type: "int", nullable: false),
                    ManufacturerpartNumber = table.Column<int>(type: "int", nullable: false),
                    Showonhomepage = table.Column<bool>(type: "bit", nullable: false),
                    ProductType = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ProductTemplate = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    VisibleIndividualy = table.Column<bool>(type: "bit", nullable: false),
                    CustomerRoles = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LimitedToStores = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    RequireotherProducts = table.Column<bool>(type: "bit", nullable: false),
                    RequiredproductIDs = table.Column<int>(type: "int", nullable: false),
                    Automaticallyaddproductstocart = table.Column<bool>(type: "bit", nullable: false),
                    Allowcustomerreviews = table.Column<bool>(type: "bit", nullable: false),
                    AvailableStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AvailableEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkAsNew = table.Column<bool>(type: "bit", nullable: false),
                    AdminComment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_Discount_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Discount",
                        principalColumn: "Discount_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_DownloadProduct_DownloadableProductId",
                        column: x => x.DownloadableProductId,
                        principalTable: "DownloadProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_GiftCards_GiftCardId",
                        column: x => x.GiftCardId,
                        principalTable: "GiftCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Inventory_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_RecurringProduct_Recurring_ProductId",
                        column: x => x.Recurring_ProductId,
                        principalTable: "RecurringProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Rental_RentalId",
                        column: x => x.RentalId,
                        principalTable: "Rental",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_SEO_SeoId",
                        column: x => x.SeoId,
                        principalTable: "SEO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Shipping_ShippingId",
                        column: x => x.ShippingId,
                        principalTable: "Shipping",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "VendorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "manufacturers",
                        principalColumn: "ManufacturerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_category_ParentCategoryId",
                table: "category",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_category_TaxId",
                table: "category",
                column: "TaxId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_DiscountId",
                table: "Product",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_DownloadableProductId",
                table: "Product",
                column: "DownloadableProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_GiftCardId",
                table: "Product",
                column: "GiftCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_InventoryId",
                table: "Product",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ManufacturerId",
                table: "Product",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Recurring_ProductId",
                table: "Product",
                column: "Recurring_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_RentalId",
                table: "Product",
                column: "RentalId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SeoId",
                table: "Product",
                column: "SeoId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ShippingId",
                table: "Product",
                column: "ShippingId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_VendorId",
                table: "Product",
                column: "VendorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Discount");

            migrationBuilder.DropTable(
                name: "DownloadProduct");

            migrationBuilder.DropTable(
                name: "GiftCards");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "RecurringProduct");

            migrationBuilder.DropTable(
                name: "Rental");

            migrationBuilder.DropTable(
                name: "SEO");

            migrationBuilder.DropTable(
                name: "Shipping");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropTable(
                name: "category");

            migrationBuilder.DropTable(
                name: "manufacturers");

            migrationBuilder.DropTable(
                name: "ParentCategory");

            migrationBuilder.DropTable(
                name: "Tax");
        }
    }
}
