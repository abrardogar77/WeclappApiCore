using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeclappApiCore.Models
{
    public class shipmentMethod
    {
        //        id(string, optional),
        public string id { get; set; }
        //version(string, optional),
        public string version { get; set; }
        //createdDate(integer, optional),
        public long createdDate { get; set; }
        //description(string, optional),
        public string description { get; set; }
        //lastModifiedDate(integer, optional),
        public long lastModifiedDate { get; set; }
        //name(string, optional)
        public string name { get; set; }
    }
}