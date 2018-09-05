using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeclappApiCore.Models
{
    public class User
    {
        //        id(string, optional),
        public string id { get; set; }
        //version(string, optional),
        public string version { get; set; }
        //createdDate(integer, optional),
        public long createdDate { get; set; }
        //email(string),
        public string email { get; set; }
        //faxNumber(string, optional),
        public string faxNumber { get; set; }
        //firstName(string, optional),
        public string firstName { get; set; }
        //lastModifiedDate(integer, optional),
        public long lastModifiedDate { get; set; }
        //lastName(string, optional),
        public string lastName { get; set; }
        //mobilePhoneNumber(string, optional),
        public string mobilePhoneNumber { get; set; }
        //phoneNumber(string, optional),
        public string phoneNumber { get; set; }
        //status(string, optional),
        public string status { get; set; }
        //username(string)
        public string username { get; set; }
    }
}