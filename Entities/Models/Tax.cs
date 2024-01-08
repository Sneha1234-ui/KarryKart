using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Tax
    {
        [Key]
        public int TaxId { get; set; }
        public string TaxCode { get; set; }
        public double SGSTPercentage { get; set; }
        public double CGSTPercentage { get; set; }
        public DateTime created_at { get; set; }
        public string Created_By { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }
       

    }


}

