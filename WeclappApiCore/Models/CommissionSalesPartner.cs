using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeclappApiCore.Models
{
    public class CommissionSalesPartner
    {
        //        id(string, optional),
        public string id { get; set; }
        //version(string, optional),
        public string version { get; set; }
        //commissionFix(string, optional),
        public string commissionFix { get; set; }
        //commissionPercentage(string, optional),
        public string commissionPercentage { get; set; }
        //commissionType(string),
        public string commissionType { get; set; }
        //createdDate(integer, optional),
        public long createdDate { get; set; }
        //lastModifiedDate(integer, optional),
        public long lastModifiedDate { get; set; }
        //salesPartnerCustomerId(string, optional),
        public string salesPartnerCustomerId { get; set; }
        //salesPartnerCustomerNumber(string, optional)
        public string salesPartnerCustomerNumber { get; set; }
    }
}