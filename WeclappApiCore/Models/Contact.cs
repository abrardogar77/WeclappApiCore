using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeclappApiCore.Models
{
    public class Contact
    {
        //id(string, optional),
        public string id { get; set; }
        //version(string, optional),
        public string version { get; set; }
        //addresses(Array[address], optional), 
        public List<Address> Address { get; set; }
        //birthDate(integer, optional),
        public long birthDate { get; set; }
        //company(string, optional),
        public string company { get; set; }
        //company2(string, optional),
        public string company2 { get; set; }
        //createdDate(integer, optional),
        public long createdDate { get; set; }
        //description(string, optional),
        public string description { get; set; }
        //email(string, optional),
        public string email { get; set; }
        //fax(string, optional),
        public string fax { get; set; }
        //firstName(string, optional),
        public string firstName { get; set; }
        //fixPhone2(string, optional),
        public string fixPhone2 { get; set; }
        //lastModifiedDate(integer, optional),
        public long lastModifiedDate { get; set; }
        //lastName(string, optional),
        public string lastName { get; set; }
        //middleName(string, optional),
        public string middleName { get; set; }
        //mobilePhone1(string, optional),
        public string mobilePhone1 { get; set; }
        //mobilePhone2(string, optional),
        public string mobilePhone2 { get; set; }
        //optIn(boolean, optional),
        public Boolean optIn { get; set; }
        //partyType(string, optional),
        public string partyType { get; set; }
        //personCompany(string, optional),
        public string personCompany { get; set; }
        //personDepartment(string, optional),
        public string personDepartment { get; set; }
        //personRole(string, optional),
        public string personRole { get; set; }
        //phone(string, optional),
        public string phone { get; set; }
        //phoneHome(string, optional),
        public string phoneHome { get; set; }
        //salutation(string, optional),
        public string salutation { get; set; }
        //title(string, optional),
        public string title { get; set; }
        //website(string, optional)
        public string website { get; set; }
        

    }
}