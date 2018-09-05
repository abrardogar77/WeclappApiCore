using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class articleImageController : Controller
    {
        // GET: articleImage
        public ActionResult Get()
        {
            // insert a little dummy data 
            // class data fields are public modiffiers you can access them here.

            articleImage artImage = new articleImage();
            artImage.id = "article id";
            artImage.version = "article version";
            return View(artImage);
        }
    }
}