using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class customAttributeDefinitionListValueController : Controller
    {
        // GET: customAttributeDefinitionListValue
        public ActionResult Get()
        {
            customAttributeDefinitionListValue value = new customAttributeDefinitionListValue();
            value.id = "dummy ID";
            value.version = "dummy version";
            value.createdDate = 12;
            value.lastModifiedDate = 30;
            value.value = "value";

            return View(value);
        }
    }
}