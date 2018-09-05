using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class shipmentStatus
    {
        //        status(string, optional),
        public string status { get; set; }
        //statusDate(integer, optional),
        public Int32 statusDate { get; set; }
        //userId(string, optional)
        public string userId { get; set; }
    }
}