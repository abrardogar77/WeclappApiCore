using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class salesBillOfMaterialArticleItemController : Controller
    {
        // GET: salesBillOfMaterialArticleItem
        public ActionResult get()
        {

            // insert a little dummy data 
            // class data fields are public modiffiers you can access them here.
            salesBillOfMaterialArticleItem bil = new salesBillOfMaterialArticleItem();
            bil.id = " id example";
            return View(bil);
        }
    }
}