using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class articlePriceWithoutArticleReference
    {

        //          id (string, optional),
        public string id { get; set; }
        public string version { get; set; }
        public Int32 createdDate { get; set; }

        //createdDate (integer, optional),
        //currencyId (string, optional),
        public string currencyId { get; set; }
        //currencyName (string, optional),
        public string currencyName { get; set; }
        //customerId (string, optional),
        public string customerId { get; set; }
        //description (string, optional),
        public string description { get; set; }
        //endDate (integer, optional),
        public Int32 endDate { get; set; }
        //lastModifiedDate (integer, optional),
        public Int32 lastModifiedDate { get; set; }
        //positionNumber (integer, optional),
        public Int32 positionNumber { get; set; }
        //price (string),
        public string price { get; set; }
        //priceScaleType (string),
        public string priceScaleType { get; set; }
        //priceScaleValue (string),
        public string priceScaleValue { get; set; }
        //reductionAdditions (Array[priceCondition], optional),

        List<priceCondition> reductionAdditions = new List<priceCondition>();

        //salesChannel (string),
        public string salesChannel { get; set; }
        //startDate (integer, optional)
        public Int32 startDate { get; set; }
        //         * 
        //         **/
    }
}