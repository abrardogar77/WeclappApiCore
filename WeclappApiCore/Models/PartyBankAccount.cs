using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeclappApiCore.Models
{
    public class PartyBankAccount
    {

        //        id(string, optional),
        public string id { get; set; }
        //version(string, optional),
        public string version { get; set; }
        //accountHolder(string, optional),
        public string accountHolder { get; set; }
        //accountNumber(string),
        public string accountNumber { get; set; }
        //bankCode(string),
        public string bankCode { get; set; }
        //createdDate(integer, optional),
        public long createdDate { get; set; }
        //creditInstitute(string, optional),
        public string lastName { get; set; }
        //lastModifiedDate(integer, optional),
        public long lastModifiedDate { get; set; }
        //primary(boolean)
        public Boolean primary { get; set; }

    }
}