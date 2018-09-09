using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeclappApiCore.Models
{
    public class productionOrderStatusHistory
    {

        //status(string, optional),
        public string status { get; set; }
        //statusDate(integer, optional),
        public long statusDate { get; set; }
        //userId(string, optional)
        public string userId { get; set; }

    }
}