using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class recordAddressController : Controller
    {
        // GET: recordAddress
        public ActionResult get()
        {
            // insert a little dummy data 
            // class data fields are public modiffiers you can access them here.
            recordAddress rAddress = new recordAddress();
            rAddress.city = "dummy city";
            rAddress.company = "dummy company";
            return View(rAddress);
        }
    }
}