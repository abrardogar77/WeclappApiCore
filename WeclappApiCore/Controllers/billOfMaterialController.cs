using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class billOfMaterialController : Controller
    {
        // GET: billOfMaterial
        public ActionResult get()
        {
            // insert a little dummy data 
            // class data fields are public modiffiers you can access them here.
            billOfMaterial bil = new billOfMaterial();
            bil.id = " id example";
            return View(bil);
        }
    }
}