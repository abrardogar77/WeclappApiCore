using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class commercialLanguage
    {
        //        id(string, optional),
        public string id { get; set; }
        //version(string, optional),
        public string version { get; set; }
        //countryCode(string, optional),
        public string countryCode { get; set; }
        //createdDate(integer, optional),
        public long createdDate { get; set; }
        //languageCode(string),
        public string languageCode { get; set; }
        //lastModifiedDate(integer, optional)
        private long lModifiedDate=0;
        public long lastModifiedDate {
            get { return lModifiedDate; } set {

                lastModifiedDate = value; }// set in unix timestamp
        }
    }
}