using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class shipmentController : Controller
    {
        // GET: shipment
        public ActionResult get()
        {
            // insert a little dummy data 
            // class data fields are public modiffiers you can access them here.
            shipment ship = new shipment();
            ship.id = "1 dummy id shipment";
            ship.version = "1.2 dummy version";
            return View(ship);
        }

    }
}