
using Entities.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public partial class Product
    {
        public double price { get; set; }
        public double OldPrice { get; set; }
        public double productCost { get; set; }
        public bool DisableBuyButton { get; set; }
        public bool DisableWishListButton { get; set; }
        public bool AvailableForPreOrder { get; set; }
        public DateTime PreOrderAvailablityStartDate { get; set; }
        public bool CallForPrice { get; set; }
        public bool CustomerEnterPrice { get; set; }
        public double MinAmount { get; set; }
        public double MaxAmount { get; set; }
        public bool pangvBasePriceEnable { get; set; }
        public double AmountInProduct { get; set; }
        // enum
        [Column(TypeName = "nvarchar(100)")]
        public UnitOfProduct unitOfProduct { get; set; }

        public double ReferenceAmount { get; set; }
        //enum
        [Column(TypeName = "nvarchar(100)")]
        public ReferenceUnitEnum ReferenceUnit { get; set; }
        // FORIGN KEY
        public int DiscountId { get; set; }
        public Discounts discount { get; set; }
        public bool TaxExpempt { get; set; }
       
        public bool TelecommunicationBoardCastingAndElectronicServices { get; set; }
        // forgin key
        public int VendorId { get; set; }
        public Vendors Vendor { get; set; }
        public DateTime Created_At { get; set; }
        public string Created_By { get; set; }
        public string Modified_By { get; set; }
        public DateTime Modified_At { get; set; }
        public bool IsDelete { get; set; }
    }
}

