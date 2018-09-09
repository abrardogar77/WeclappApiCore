using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WeclappApiCore.Models
{
    public class salesOrder
    {
        //        id(string, optional),
        public string id { get; set; }
        //version(string, optional),
        public string version { get; set; }
        //commercialLanguage(string, optional),
        public string commercialLanguage { get; set; }
        //commission(string, optional),
        public string commission { get; set; }
        //commissionSalesPartners(Array[commissionSalesPartner], optional),
        public List<commissionSalesPartner> commissionSalesPartner = new List<commissionSalesPartner>();

        //createdDate(integer, optional),
        public long createdDate { get; set; }
        //customerId(string, optional),
        public string customerId { get; set; }
        //customerNumber(string, optional),
        public string customerNumber { get; set; }
        //grossAmount(string, optional),
        public string grossAmount { get; set; }
        //grossAmountInCompanyCurrency(string, optional),
        public string grossAmountInCompanyCurrency { get; set; }
        //headerDiscount(string, optional),
        public string headerDiscount { get; set; }
        //headerSurcharge(string, optional),
        public string headerSurcharge { get; set; }
        //invoiceDate(integer, optional),
        public long invoiceDate { get; set; }
        //invoiceNumber(string, optional),
        public string invoiceNumber { get; set; }
        //lastModifiedDate(integer, optional),
        public long lastModifiedDate { get; set; }
        //netAmount(string, optional),
        public string netAmount { get; set; }
        //netAmountInCompanyCurrency(string, optional),
        public string netAmountInCompanyCurrency { get; set; }
        //nonStandardTaxId(string, optional),
        public string nonStandardTaxId { get; set; }
        //nonStandardTaxName(string, optional),
        public string nonStandardTaxName { get; set; }
        //orderNumberAtCustomer(string, optional),
        public string orderNumberAtCustomer { get; set; }
        //paymentMethodId(string, optional),
        public string paymentMethodId { get; set; }
        //paymentMethodName(string, optional),
        public string paymentMethodName { get; set; }
        //pricingDate(integer, optional),
        public long pricingDate { get; set; }
        //recordAddress(recordAddress, optional),
        public List<recordAddress> recordAddress = new List<WebApplication1.Models.recordAddress>();

        //recordComment(string, optional),
        public string recordComment { get; set; }
        //recordCurrencyId(string, optional),
        public string recordCurrencyId { get; set; }
        //recordCurrencyName(string, optional),
        public string recordCurrencyName { get; set; }
        //recordFreeText(string, optional),
        public string recordFreeText { get; set; }
        //recordOpening(string, optional),
        public string recordOpening { get; set; }
        //responsibleUserId(string, optional),
        public string responsibleUserId { get; set; }
        //responsibleUserUsername(string, optional),
        public string responsibleUserUsername { get; set; }
        //salesChannel(string, optional),
        public string salesChannel { get; set; }
        //salesInvoiceItems(Array[salesInvoiceItem], optional),
        public List<salesInvoiceItem> salesInvoiceItems = new List<salesInvoiceItem>();
        //salesInvoiceType(string, optional),
        public string salesInvoiceType { get; set; }
        //salesOrderId(string, optional),
        public string salesOrderId { get; set; }
        //salesOrderNumber(string, optional),
        public string salesOrderNumber { get; set; }
        //sentToRecipient(boolean, optional),
        public Boolean sentToRecipient { get; set; }
        //servicePeriodFrom(integer, optional),
        public long servicePeriodFrom { get; set; }
        //servicePeriodTo(integer, optional),
        public long servicePeriodTo { get; set; }
        //shipmentMethodId(string, optional),
        public string shipmentMethodId { get; set; }
        //shipmentMethodName(string, optional),
        public string shipmentMethodName { get; set; }
        //shippingCostItems(Array[salesShippingCostItem], optional),
        public List<salesShippingCostItem> shippingCostItems = new List<salesShippingCostItem>();
        //status(string),
        public string status { get; set; }
        //statusHistory(Array[invoiceStatusHistory], optional),
        public List<InvoiceStatusHistory> statusHistory = new List<InvoiceStatusHistory>();
        //termOfPaymentId(string, optional),
        public string termOfPaymentId { get; set; }
        //termOfPaymentName(string, optional),
        public string termOfPaymentName { get; set; }
        //vatRegistrationNumber(string, optional)
        public string vatRegistrationNumber { get; set; }
        // custom attribute
        public List<customAttributeDefinition> customAttributeDefinition = new List<WebApplication1.Models.customAttributeDefinition>();


    }
}