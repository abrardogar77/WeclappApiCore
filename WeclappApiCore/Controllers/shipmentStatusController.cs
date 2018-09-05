using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class shipmentStatusController : Controller
    {
        // GET: shipmentStatus
        public ActionResult get()
        {
            // insert a little dummy data 
            // class data fields are public modiffiers you can access them here.
            shipmentStatus status = new shipmentStatus();
            status.status = "dummy status";
            status.userId = "user id ";
            return View(status);
        }
    }
}