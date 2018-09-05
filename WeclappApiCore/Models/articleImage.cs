using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class articleImage
    {
        //        id(string, optional),
        public string id { get; set; }
        public string version { get; set; }
        public Int32 createdDate { get; set; }
        //version(string, optional),

        //createdDate(integer, optional),
        //fileName(string, optional),
        public string fileName { get; set; }
        //lastModifiedDate(integer, optional),
        public Int32 lastModifiedDate { get; set; }
        //mainImage(boolean, optional)
        public Boolean mainImage { get; set; }
    }
}