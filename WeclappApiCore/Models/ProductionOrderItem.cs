using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeclappApiCore.Models
{
    public class productionOrderItem
    {

        //id(string, optional),
        public string id { get; set; }
        //version(string, optional),
        public string version { get; set; }
        //actualWithdrawalDate(integer, optional),
        public long actualWithdrawalDate { get; set; }
        //actualWithdrawalQuantity(string),
        public string actualWithdrawalQuantity { get; set; }
        //articleId(string, optional),
        public string articleId { get; set; }
        //articleNumber(string, optional),
        public string articleNumber { get; set; }
        //createdDate(integer, optional),
        public long createdDate { get; set; }
        //lastModifiedDate(integer, optional),
        public long lastModifiedDate { get; set; }
        //note(string, optional),
        public string note { get; set; }
        //positionNumber(integer, optional),
        public string positionNumber { get; set; }
        //quantity(string, optional),
        public string quantity { get; set; }
        //targetWithdrawalDate(integer, optional),
        public long targetWithdrawalDate { get; set; }
        //targetWithdrawalQuantity(string)
        public string targetWithdrawalQuantity { get; set; }
    }
}