﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WeclappApiCore.Models
{
    public class productionOrder
    {

        //id(string, optional),
        public string id { get; set; }
        //version(string, optional),
        public string version { get; set; }
        //actualEndDate(integer, optional),
        public long actualEndDate { get; set; }
        //actualQuantity(string),
        public string actualQuantity { get; set; }
        //actualStartDate(integer, optional),
        public long actualStartDate { get; set; }
        //articleId(string, optional),
        public string articleId { get; set; }
        //articleNumber(string, optional),
        public string articleNumber { get; set; }
        //createdDate(integer, optional),
        public long createdDate { get; set; }
        //lastModifiedDate(integer, optional),
        public long lastModifiedDate { get; set; }
        //productionOrderItems(Array[productionOrderItem], optional),

        public List<productionOrderItem> productionOrderItems = new List<productionOrderItem>();

        //productionOrderNumber(string),
        public string productionOrderNumber { get; set; }
        //status(string),
        public string status { get; set; }
        //statusHistory(Array[productionOrderStatusHistory], optional),

        public List<productionOrderStatusHistory> statusHistory = new List<productionOrderStatusHistory>();

        //targetEndDate(integer),
        public long targetEndDate { get; set; }
        //targetQuantity(string),
        public string targetQuantity { get; set; }
        //targetStartDate(integer),
        public long targetStartDate { get; set; }
        //warehouseId(string, optional),
        public string warehouseId { get; set; }
        //warehouseName(string, optional)
        public string warehouseName { get; set; }

        // custom attribute
        public List<customAttributeDefinition> customAttributeDefinition = new List<WebApplication1.Models.customAttributeDefinition>();


       


      

    }
}