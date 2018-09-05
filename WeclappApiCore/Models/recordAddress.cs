using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class recordAddress
    {
        //        city(string, optional),
        public string city { get; set; }
        //company(string, optional),
        public string company { get; set; }
        //company2(string, optional),
        public string company2 { get; set; }
        //countryCode(string, optional)
        public string countryCode { get; set; }

        //firstName(string, optional),
        public string firstName { get; set; }
        //globalLocationNumber(string, optional),
        public string globalLocationNumber { get; set; }
        //lastName(string, optional),
        public string lastName { get; set; }
        //middleName(string, optional),
        public string middleName { get; set; }
        //postOfficeBoxCity(string, optional),
        public string postOfficeBoxCity { get; set; }
        //postOfficeBoxNumber(string, optional),
        public string postOfficeBoxNumber { get; set; }
        //postOfficeBoxZipCode(string, optional),
        public string postOfficeBoxZipCode { get; set; }
        //salutation(string, optional),
        public string salutation { get; set; }
        //state(string, optional),
        public string state { get; set; }
        //street1(string, optional),
        public string street1 { get; set; }
        //street2(string, optional),
        public string street2 { get; set; }
        //title(string, optional),
        public string title { get; set; }
        //zipcode(string, optional)
        public string zipcode { get; set; }
    }
}