using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WeclappApiCore.Models
{
    public class customer
    {
        
        //        id(string, optional),
        public string id { get; set; }
        //version(string, optional),
        public string version { get; set; }
        //addresses(Array[address], optional),
        public List<address> addresses = new List<address>();
        //amountInsured(string, optional),
        public string amountInsured { get; set; }
        //annualRevenue(string, optional),
        public string annualRevenue { get; set; }
        //bankAccounts(Array[partyBankAccount], optional), 
        public List<partyBankAccount> bankAccounts = new List<partyBankAccount>();
         //birthDate(integer, optional),
        public long birthDate { get; set; }
        //blockNotice(string, optional),
        public string blockNotice { get; set; }
        //blocked(boolean, optional),
        public string blocked { get; set; }
        //commercialLanguageId(string, optional),
        public string commercialLanguageId { get; set; }
        //commissionSalesPartners(Array[commissionSalesPartner], optional), 
        public List<commissionSalesPartner> commissionSalesPartners = new List<commissionSalesPartner>();
        //company(string, optional),
        public string company { get; set; }
        //company2(string, optional),
        public string company2 { get; set; }
        //companySizeId(string, optional),
        public string companySizeId { get; set; }
        //companySizeName(string, optional),
        public string companySizeName { get; set; }
        //contacts(Array[contact], optional),
        public List<contact> contacts = new List<contact>();
        //createdDate(integer, optional),
        public long createdDate { get; set; }
        //creditLimit(string, optional),
        public string creditLimit { get; set; }
        //currencyId(string, optional),
        public string currencyId { get; set; }
        //currencyName(string, optional),
        public string currencyName { get; set; }
        //customerCategoryId(string, optional),
        public string customerCategoryId { get; set; }
        //customerCategoryName(string, optional),
        public string customerCategoryName { get; set; }
        //customerNumber(string, optional),
        public string customerNumber { get; set; }
        //customerRating(string, optional),
        public string customerRating { get; set; }
        //customerTopics(Array[entitiy], optional),
        public List<entity> customerTopics = new List<entity>();
        //defaultHeaderDiscount(string, optional),
        public string defaultHeaderDiscount { get; set; }
        //defaultHeaderSurcharge(string, optional),
        public string defaultHeaderSurcharge { get; set; }
        //deliveryBlock(boolean, optional),
        public Boolean deliveryBlock { get; set; }
        //description(string, optional),
        public string description { get; set; }
        //email(string, optional),
        public string email { get; set; }
        //fax(string, optional),
        public string fax { get; set; }
        //firstName(string, optional),
        public string MyProperty { get; set; }
        //insolvent(boolean, optional),
        public Boolean insolvent { get; set; }
        //insured(boolean, optional),
        public Boolean insured { get; set; }
        //invoiceContactId(string, optional),
        public string invoiceContactId { get; set; }
        //lastModifiedDate(integer, optional),
        public long lastModifiedDate { get; set; }
        //lastName(string, optional),
        public string lastName { get; set; }
        //leadSourceId(string, optional),
        public string leadSourceId { get; set; }
        //leadSourceName(string, optional),
        public string leadSourceName { get; set; }
        //lossDescription(string, optional),
        public string lossDescription { get; set; }
        //lossReasonId(string, optional),
        public string lossReasonId { get; set; }
        //lossReasonName(string, optional),
        public string lossReasonName { get; set; }
        //middleName(string, optional),
        public string middleName { get; set; }
        //mobilePhone1(string, optional),
        public string mobilePhone1 { get; set; }
        //oldCustomerNumber(string, optional),
        public string oldCustomerNumber { get; set; }
        //optIn(boolean, optional),
        public Boolean optIn { get; set; }
        //parentPartyId(string, optional),
        public string parentPartyId { get; set; }
        //partyType(string, optional),
        public string partyType { get; set; }
        //paymentMethodId(string, optional),
        public string paymentMethodId { get; set; }
        //paymentMethodName(string, optional),
        public string paymentMethodName { get; set; }
        //personCompany(string, optional),
        public string personCompany { get; set; }
        //personDepartment(string, optional),
        public string personDepartment { get; set; }
        //personRole(string, optional),
        public string personRole { get; set; }
        //phone(string, optional),
        public string phone { get; set; }
        //primaryContactId(string, optional),
        public string primaryContactId { get; set; }
        //responsibleUserFixed(boolean, optional),
        public Boolean responsibleUserFixed { get; set; }
        //responsibleUserId(string, optional),
        public string responsibleUserId { get; set; }
        //responsibleUserUsername(string, optional),
        public string responsibleUserUsername { get; set; }
        //salesChannel(string, optional),
        public string salesChannel { get; set; }
        //salesPartner(boolean),
        public Boolean salesPartner { get; set; }
        //salesPartnerDefaultCommissionFix(string, optional),
        public string salesPartnerDefaultCommissionFix { get; set; }
        //salesPartnerDefaultCommissionPercentage(string, optional),
        public string salesPartnerDefaultCommissionPercentage { get; set; }
        //salesPartnerDefaultCommissionType(string, optional),
        public string salesPartnerDefaultCommissionType { get; set; }
        //salesStageId(string, optional),
        public string salesStageId { get; set; }
        //salesStageName(string, optional),
        public string salesStageName { get; set; }
        //salutation(string, optional),
        public string salutation { get; set; }
        //satisfaction(string, optional),
        public string satisfaction { get; set; }
        //sectorId(string, optional),
        public string sectorId { get; set; }
        //sectorName(string, optional),
        public string sectorName { get; set; }
        //shipmentMethodId(string, optional),
        public string shipmentMethodId { get; set; }
        //shipmentMethodName(string, optional),
        public string shipmentMethodName { get; set; }
        //termOfPaymentId(string, optional),
        public string termOfPaymentId { get; set; }
        //termOfPaymentName(string, optional),
        public string termOfPaymentName { get; set; }
        //title(string, optional),
        public string title { get; set; }
        //useCustomsTariffNumber(boolean, optional),
        public Boolean useCustomsTariffNumber { get; set; }
        //vatRegistrationNumber(string, optional),
        public string vatRegistrationNumber { get; set; }
        //website(string, optional)
        public string website { get; set; }

        // custom Attribute 
        public List<customAttributeDefinition> customAttributes = new List<customAttributeDefinition>();


    }
}