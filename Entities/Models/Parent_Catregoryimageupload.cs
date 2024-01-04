using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Parent_Catregoryimageupload
    {
        public class ParentCategory_imgupl
        {
            public ImageUpload imgUploads { get; set; }
            public Parent_Category parent_Catgories { get; set; }
            public List<Parent_Category> parent_CatgList { get; set; }
        }

    }
}
