using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class customAttributeDefinitionLabelController : Controller
    {
        // GET: customAttributeDefinitionLabel
        public ActionResult get()
        {
            customAttributeDefinitionLabel label = new customAttributeDefinitionLabel();
            label.labelText = "lable dummy text";
            label.locale = "local dummy ";
            return View(label);
        }
    }
}