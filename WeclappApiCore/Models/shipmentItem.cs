using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class shipmentItem
    {
        //        id(string, optional),
        public string id { get; set; }
        //version(string, optional),
        public string version { get; set; }
        //addPageBreakBefore(boolean, optional),
        public Boolean addPageBreakBefore { get; set; }
        //articleId(string, optional),
        public string articleId { get; set; }
        //articleNumber(string, optional),
        public string articleNumber { get; set; }
        //createdDate(integer, optional),
        public Int32 createdDate { get; set; }
        //description(string, optional),
        public string description { get; set; }
        //freeTextItem(boolean, optional),
        public Boolean freeTextItem { get; set; }
        //groupName(string, optional),
        public string groupName { get; set; }
        //lastModifiedDate(integer, optional),
        public Int32 lastModifiedDate { get; set; }
        //note(string, optional),
        public string note { get; set; }
        //parentItemId(string, optional),
        public string parentItemId { get; set; }
        //positionNumber(integer, optional),
        public Int32 positionNumber { get; set; }
        //quantity(string, optional),
        public string quantity { get; set; }
        //title(string, optional),
        public string title { get; set; }
        //unitId(string, optional),
        public string unitId { get; set; }
        //unitName(string, optional)
        public string unitName { get; set; }
    }
}