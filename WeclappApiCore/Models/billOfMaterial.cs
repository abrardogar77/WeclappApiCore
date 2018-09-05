using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class billOfMaterial
    {
        //        id(string, optional),
        public string id { get; set; }
        public string version { get; set; }
        public string articleId { get; set; }
        public string articleNumber { get; set; }
        public Int32 createdDate { get; set; }
        public Int32 lastModifiedDate { get; set; }
        public Int32 positionNumber { get; set; }
        public string quantity { get; set; }
                                           //version(string, optional),
                                           //articleId(string, optional),
                                           //articleNumber(string, optional),
                                           //createdDate(integer, optional),
                                           //lastModifiedDate(integer, optional),
                                           //positionNumber(integer, optional),
                                           //quantity(string)
    }
}