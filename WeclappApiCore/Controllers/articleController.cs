using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class articleController : Controller
    {
        // GET: article
             [HttpGet]
        public ActionResult Get()
        {
            // insert a little dummy data 
            // class data fields are public modiffiers you can access them here.
            article article = new article();
            article.id = "article id";
            article.version = "article version";
            

            return View(article);
        }
    }
}