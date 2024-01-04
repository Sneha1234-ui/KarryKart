using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ImageUpload
    {
        public int ImgId { get; set; }
        public string ImgName { get; set; }
        public IFormFile files { get; set;}
        

    }
}
