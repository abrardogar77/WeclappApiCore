using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class shipmentItemController : Controller
    {
        // GET: shipmentItem
        public ActionResult get()
        {
            // insert a little dummy data 
            // class data fields are public modiffiers you can access them here.
            shipmentItem shipItem = new shipmentItem();
            shipItem.id = "dummy id";
            shipItem.version = "dummy version";
            return View(shipItem);
        }
    }
}