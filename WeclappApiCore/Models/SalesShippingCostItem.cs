using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeclappApiCore.Models
{
    public class salesShippingCostItem
    {
        //id(string, optional),
        public string id { get; set; }
        //version(string, optional),
        public string version { get; set; }
        //articleId(string, optional),
        public string articleId { get; set; }
        //articleNumber(string, optional),
        public string articleNumber { get; set; }
        //createdDate(integer, optional),
        public long createdDate { get; set; }
        //grossAmount(string, optional),
        public string grossAmount { get; set; }
        //grossAmountInCompanyCurrency(string, optional),
        public string grossAmountInCompanyCurrency { get; set; }
        //lastModifiedDate(integer, optional),
        public long lastModifiedDate { get; set; }
        //manualUnitCost(boolean, optional),
        public Boolean manualUnitCost { get; set; }
        //manualUnitPrice(boolean, optional),
        public Boolean manualUnitPrice { get; set; }
        //netAmount(string, optional),
        public string netAmount { get; set; }
        //netAmountInCompanyCurrency(string, optional),
        public string netAmountInCompanyCurrency { get; set; }
        //taxId(string, optional),
        public string taxId { get; set; }
        //taxName(string, optional),
        public string taxName { get; set; }
        //unitCost(string, optional),
        public string unitCost { get; set; }
        //unitCostInCompanyCurrency(string, optional),
        public string unitCostInCompanyCurrency { get; set; }
        //unitPrice(string, optional),
        public string unitPrice { get; set; }
        //unitPriceInCompanyCurrency(string, optional)
        public string unitPriceInCompanyCurrency { get; set; }


    }
}