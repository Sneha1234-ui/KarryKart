
using Entities.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public partial class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string SKU { get; set; }

        // foreign key
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public bool Published { get; set; }
        public string ProductTags { get; set; }
        public int GTINNumber { get; set; }
        public int ManufacturerpartNumber { get; set; }
        public bool Showonhomepage { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public ProductTypeEnum ProductType { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public ProductTemplateEnum ProductTemplate { get; set; }
        public bool VisibleIndividualy { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public CustomerRolesEnum CustomerRoles { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public limitedToStoresEnum LimitedToStores { get; set; }
        
        public bool RequireotherProducts { get; set; }
        public int RequiredproductIDs { get; set; }
        public bool Automaticallyaddproductstocart { get; set; }
        public bool Allowcustomerreviews { get; set; }
        public DateTime AvailableStartDate { get; set; }
        public DateTime AvailableEndDate { get; set; }
        public bool MarkAsNew { get; set; }
        public string AdminComment { get; set; }
    }
}
