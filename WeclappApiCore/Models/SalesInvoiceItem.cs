using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeclappApiCore.Models
{
    public class salesInvoiceItem
    {

        //id(string, optional),
        public string id { get; set; }
        //version(string, optional),
        public string version { get; set; }
        //addPageBreakBefore(boolean, optional),
        public Boolean addPageBreakBefore { get; set; }
        //articleId(string, optional),
        public string articleId { get; set; }
        //articleNumber(string, optional),
        public string articleNumber { get; set; }
        //createdDate(integer, optional),
        public long createdDate { get; set; }
        //description(string, optional),
        public string description { get; set; }
        //discountPercentage(string, optional),
        public string discountPercentage { get; set; }
        //freeTextItem(boolean, optional),
        public Boolean freeTextItem { get; set; }
        //grossAmount(string, optional),
        public string grossAmount { get; set; }
        //grossAmountInCompanyCurrency(string, optional),
        public string grossAmountInCompanyCurrency { get; set; }
        //groupName(string, optional),
        public string groupName { get; set; }
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
        //note(string, optional),
        public string note { get; set; }
        //parentItemId(string, optional),
        public string parentItemId { get; set; }
        //positionNumber(integer, optional),
        public long positionNumber { get; set; }
        //quantity(string, optional),
        public string quantity { get; set; }
        //reductionAdditionItems(Array[reductionAdditionItem], optional),
        public List<reductionAdditionItem> reductionAdditionItems = new List<reductionAdditionItem>();
        //taxId(string, optional),
        public string taxId { get; set; }
        //taxName(string, optional),
        public string taxName { get; set; }
        //title(string, optional),
        public string title { get; set; }
        //unitCost(string, optional),
        public string unitCost { get; set; }
        //unitCostInCompanyCurrency(string, optional),
        public string unitCostInCompanyCurrency { get; set; }
        //unitId(string, optional),
        public string unitId { get; set; }
        //unitName(string, optional),
        public string unitName { get; set; }
        //unitPrice(string, optional),
        public string unitPrice { get; set; }
        //unitPriceInCompanyCurrency(string, optional)
        public string unitPriceInCompanyCurrency { get; set; }

    }
}