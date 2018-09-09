using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeclappApiCore.Models
{
    public class address
    {
        //        id(string, optional),
        public string id { get; set; }
        //version(string, optional),
        public string version { get; set; }
        //city(string, optional),
        public string city { get; set; }
        //company(string, optional),
        public string company { get; set; }
        //company2(string, optional),
        public string company2 { get; set; }
        //countryCode(string, optional),
        public string countryCode { get; set; }
        //createdDate(integer, optional),
        public long createdDate { get; set; }
        //deliveryAddress(boolean, optional),
        public Boolean deliveryAddress { get; set; }
        //globalLocationNumber(string, optional),
        public string globalLocationNumber { get; set; }
        //invoiceAddress(boolean, optional),
        public Boolean invoiceAddress { get; set; }
        //lastModifiedDate(integer, optional),
        public long lastModifiedDate { get; set; }
        //postOfficeBoxCity(string, optional),
        public string postOfficeBoxCity { get; set; }
        //postOfficeBoxNumber(string, optional),
        public string postOfficeBoxNumber { get; set; }
        //postOfficeBoxZipCode(string, optional),
        public string postOfficeBoxZipCode { get; set; }
        //primeAddress(boolean),
        public string primeAddress { get; set; }
        //state(string, optional),
        public string state { get; set; }
        //street1(string, optional),
        public string street1 { get; set; }
        //street2(string, optional),
        public string street2 { get; set; }
        //zipcode(string, optional)
        public string zipcode { get; set; }
    }
}