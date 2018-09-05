using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeclappApiCore.Models
{
    public class currency
    {
        //        id(string, optional),
        public string id { get; set; }
        //version(string, optional),
        public string version { get; set; }
        //createdDate(integer, optional),
        public long createdDate { get; set; }

        //currencySymbol(string, optional),
        public string currencySymbol { get; set; }
        //lastModifiedDate(integer, optional),
        public long lastModifiedDate { get; set; }
        //name(string, optional)
        public string name { get; set; }
    }
}