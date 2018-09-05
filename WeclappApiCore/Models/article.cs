using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class article
    {
        //        id(string, optional),

        public string id { get; set; }

        //version(string, optional),
        public string version { get; set; }
        //active(boolean, optional),
        public bool active { get; set; }
        //amazonASIN(string, optional),
        public string amazonASIN { get; set; }
        //amazonSKU(string, optional),
        public string amazonSKU { get; set; }
        //applyCashDiscount(boolean, optional),
        public Boolean applyCashDiscount { get; set; }
        //articleCategoryId(string, optional),
        public string articleCategoryId { get; set; }
        //articleGrossWeight(string, optional),
        public string articleGrossWeight { get; set; }
        //articleHeight(string, optional),
        public string articleHeight { get; set; }
        //articleImages(Array[articleImage], optional),

        List<articleImage> articleImages = new List<articleImage>();

        //articleLength(string, optional),
        public string articleLength { get; set; }
        //articleNetWeight(string, optional),
        public string articleNetWeight { get; set; }
        //articleNumber(string, optional),
        public string articleNumber { get; set; }
        //articlePrices(Array[articlePriceWithoutArticleReference], optional),

      public  List<articlePriceWithoutArticleReference> articlePrices = new List<articlePriceWithoutArticleReference>();

        //articleWidth(string, optional),
        public string articleWidth { get; set; }

        //availableInSale(boolean, optional),
        public bool availableInSale { get; set; }
        //batchNumberRequired(boolean, optional),
        public bool batchNumberRequired { get; set; }
        //createdDate(integer, optional),
        public Int32 createdDate { get; set; }
        //customsTariffNumber(string, optional),
        public string customsTariffNumber { get; set; }
        //customsTariffNumberId(string, optional),
        public string customsTariffNumberId { get; set; }
        //defaultWarehouseLevels(Array[onlyId], optional),

       public List<onlyId> defaultWarehouseLevels = new List<onlyId>();

        //description(string, optional),
        public string description { get; set; }
        //ean(string, optional),
        public string ean { get; set; }
        //expirationDays(integer, optional),
        public Int32 expirationDays { get; set; }
        //lastModifiedDate(integer, optional),
        public Int32 lastModifiedDate { get; set; }
        //longText(string, optional),
        public string longText { get; set; }
        //manufacturerId(string, optional),
        public string manufacturerId { get; set; }
        //manufacturerName(string, optional),
        public string manufacturerName { get; set; }
        //manufacturerPartNumber(string, optional),
        public string manufacturerPartNumber { get; set; }
        //marginCalculationPriceType(string, optional),
        public string marginCalculationPriceType { get; set; }
        //matchCode(string, optional),
        public string matchCode { get; set; }
        //name(string),
        public string name { get; set; }
        //productionArticle(boolean, optional),
        public Boolean productionArticle { get; set; }
        //productionBillOfMaterialItems(Array[billOfMaterial], optional),

        //public billOfMaterial productionBillOfMaterialItems { get; set; }
       public List<billOfMaterial> productionBillOfMaterialItems = new List<billOfMaterial>();
        //salesBillOfMaterialArticle(boolean, optional),
        public Boolean MyProperty { get; set; }
        //salesBillOfMaterialItems(Array[salesBillOfMaterialArticleItem], optional),

        
        //list item
       public List<salesBillOfMaterialArticleItem> salesBillOfMaterialItems = new List<salesBillOfMaterialArticleItem>();
        //serialNumberRequired(boolean, optional),
        public Boolean serialNumberRequired { get; set; }
        //serviceArticle(boolean, optional),
        public Boolean serviceArticle { get; set; }
        //shippingCostArticle(boolean, optional),
        public Boolean shippingCostArticle { get; set; }
        //shortDescription1(string, optional),
        public string shortDescription1 { get; set; }
        //shortDescription2(string, optional),
        public string shortDescription2 { get; set; }
        //showOnDeliveryNote(boolean, optional),
        public Boolean showOnDeliveryNote { get; set; }
        //storable(boolean, optional),
        public Boolean storable { get; set; }
        //supplySources(Array[supplySource], optional),

       public List<supplySource> supplySources = new List<supplySource>();

        //taxId(string, optional),
        public string taxId { get; set; }
        //taxName(string, optional),
        public string taxName { get; set; }
        //unitId(string, optional),
        public string unitId { get; set; }
        //unitName(string, optional),
        public string unitName { get; set; }
        //useAvailableForSalesChannels(boolean, optional)
        public Boolean useAvailableForSalesChannels { get; set; }

    }
}