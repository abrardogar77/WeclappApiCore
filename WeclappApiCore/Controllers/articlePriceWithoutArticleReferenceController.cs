using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class articlePriceWithoutArticleReferenceController : Controller
    {
        // GET: articlePriceWithoutArticleReference
        public ActionResult Get()
        {
            // insert a little dummy data 
            // class data fields are public modiffiers you can access them here.

            articlePriceWithoutArticleReference APWARC = new articlePriceWithoutArticleReference();
            APWARC.id = "article id";
            APWARC.version = "article version";
            return View(APWARC);
        }
    }
}