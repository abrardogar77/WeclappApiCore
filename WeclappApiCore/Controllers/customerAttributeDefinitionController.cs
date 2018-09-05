using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class customerAttributeDefinitionController : Controller
    {
        // GET: customerAttributeDefinition
        public ActionResult Get()
        {
            customAttributeDefinition obj = new customAttributeDefinition();
            obj.id = "1";
            obj.version = "1.2";
            return View(obj);
        }
    }
}