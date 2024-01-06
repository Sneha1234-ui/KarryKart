using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Manufacturers
    {
        public int Id { get; set; }
        public string ManufacturerName { get; set; }
        public string ManufacturerDescription { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
       
    }
}
