﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeclappApiCore.Models
{
    public class Tax
    {
        //        id(string, optional),
        public string id { get; set; }
        //version(string, optional),
        public string version { get; set; }
        //createdDate(integer, optional),
        public long createdDate { get; set; }
        //lastModifiedDate(integer, optional),
        public long lastModifiedDate { get; set; }
        //name(string),
        public string name { get; set; }
        //taxType(string),
        public string taxType { get; set; }
        //taxValue(string)
        public string taxValue { get; set; }
    }
}