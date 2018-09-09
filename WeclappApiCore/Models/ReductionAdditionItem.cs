using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeclappApiCore.Models
{
    public class reductionAdditionItem
    {

        //position(integer, optional),
        public long position { get; set; }

        //source(string, optional),
        public string source { get; set; }
        //type(string, optional),
        public string type { get; set; }
        //value(string, optional)
        public string value { get; set; }

    }
}