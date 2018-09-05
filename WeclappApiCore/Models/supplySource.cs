using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class supplySource
    {
        //        id(string, optional),
        public string id { get; set; }
        public string version { get; set; }


        //articleSupplySourceId(string, optional),
        public string articleSupplySourceId { get; set; }
        //createdDate(integer, optional),
        public Int32 createdDate { get; set; }
        //lastModifiedDate(integer, optional)
        public Int32 lastModifiedDate { get; set; }
    }
}