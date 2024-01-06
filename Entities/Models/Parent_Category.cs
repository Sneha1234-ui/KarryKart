using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Parent_Category
    {
        public int Id { get; set; }
        public string Parent_Category_Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public ParentCategoryEnum ParentCategory { get; set; }
        
        public enum ParentCategoryEnum
        {
            Computers,
            Electronics,
            Apparel,
            Computer,
            DownloadableProduct,
            RentalProduct,
            RecurringProduct


        }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }


    }
}
