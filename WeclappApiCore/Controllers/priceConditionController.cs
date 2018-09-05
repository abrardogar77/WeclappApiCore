using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class priceConditionController : Controller
    {
        // GET: priceCondition
        public ActionResult get()
        {
            // insert a little dummy data 
            // class data fields are public modiffiers you can access them here.
            priceCondition priceCon = new priceCondition();
            priceCon.id = "1 dummy id";
            priceCon.version = "1.2 dummy version";
            return View(priceCon);
        }
    }
}