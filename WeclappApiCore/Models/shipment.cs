using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class shipment
    {
        //             id(string, optional),
        public string id { get; set; }
        //version(string, optional),
        public string version { get; set; }
        //additionalDeliveryInformation(string, optional),
        public string additionalDeliveryInformation { get; set; }
        //commercialLanguage(string, optional),
        public string commercialLanguage { get; set; }
        //createdDate(integer, optional),
        public Int32 createdDate { get; set; }
        //estimatedShippingDate(integer, optional),
        public Int32 estimatedShippingDate { get; set; }
        //lastModifiedDate(integer, optional),
        public Int32 lastModifiedDate { get; set; }
        //packageReferenceNumber(string, optional),
        public string packageReferenceNumber { get; set; }
        //packageTrackingNumber(string, optional),
        public string packageTrackingNumber { get; set; }
        //packageTrackingUrl(string, optional),
        public string packageTrackingUrl { get; set; }
        //packageWeight(string, optional),
        public string packageWeight { get; set; }
        //pickingInstructions(string, optional),
        public string pickingInstructions { get; set; }
        //recipientAddress(recordAddress, optional),

        public recordAddress recipientAddress { get; set; }

        //recipientCustomerNumber(string, optional),
        public string recipientCustomerNumber { get; set; }
        //recipientPartyId(string, optional),
        public string recipientPartyId { get; set; }
        //recipientSupplierNumber(string, optional),
        public string recipientSupplierNumber { get; set; }
        //recordComment(string, optional),
        public string recordComment { get; set; }
        //recordFreeText(string, optional),
        public string recordFreeText { get; set; }
        //recordOpening(string, optional),
        public string recordOpening { get; set; }
        //salesOrderId(string, optional),
        public string salesOrderId { get; set; }
        //salesOrderNumber(string, optional),
        public string salesOrderNumber { get; set; }
        //sentToRecipient(boolean, optional),
        public Boolean sentToRecipient { get; set; }

        //shipmentItems(Array[shipmentItem], optional),


        List<shipmentItem> shipmentItems = new List<shipmentItem>();

        //shipmentMethodId(string, optional),
        public string shipmentMethodId { get; set; }
        //shipmentMethodName(string, optional),
        public string shipmentMethodName { get; set; }
        //shipmentNumber(string, optional),
        public string shipmentNumber { get; set; }
        //shipmentType(string, optional),
        public string shipmentType { get; set; }
        //shippingCarrier(string, optional),
        public string shippingCarrier { get; set; }
        //status(string),
        public string status { get; set; }
        //statusHistory(Array[shipmentStatus], optional),

        List<shipmentStatus> statusHistory = new List<shipmentStatus>();

        //warehouseId(string, optional),
        public string warehouseId { get; set; }
        //warehouseName(string, optional)
        public string warehouseName { get; set; }

    }
}