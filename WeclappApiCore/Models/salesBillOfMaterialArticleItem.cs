using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class salesBillOfMaterialArticleItem
    {
        public string id { get; set; }
        public string version { get; set; }
        public string articleId { get; set; }
        public string articleNumber { get; set; }
        public Int32 createdDate { get; set; }
        public Int32 lastModifiedDate { get; set; }
        public Int32 positionNumber { get; set; }
        public string quantity { get; set; }
    }
}