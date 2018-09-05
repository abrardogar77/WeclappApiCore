using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class priceCondition
    {
        public string id { get; set; }
        public string version { get; set; }
        //createdDate(integer, optional),
        public Int32 createdDate { get; set; }
        //lastModifiedDate(integer, optional)
        public Int32 lastModifiedDate { get; set; }
        public string type { get; set; }
        public string valuu { get; set; }
    }
}