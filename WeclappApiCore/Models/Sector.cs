using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeclappApiCore.Models
{
    public class Sector
    {
        //        id(string, optional),
        public string id { get; set; }
        //version(string, optional),
        public string version { get; set; }
        //active(boolean, optional),
        public Boolean active { get; set; }
        //createdDate(integer, optional),
        public long createdDate { get; set; }
        //lastModifiedDate(integer, optional),
        public long lastModifiedDate { get; set; }
        //name(string),
        public string name { get; set; }
        //positionNumber(integer, optional)
        public long positionNumber { get; set; }
    }
}