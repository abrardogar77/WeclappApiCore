﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class supplySourceController : Controller
    {
        // GET: supplySource
        public ActionResult get()
        {
            // insert a little dummy data 
            // class data fields are public modiffiers you can access them here.
            supplySource supSrc = new supplySource();
            supSrc.id = "1 dummy id";
            supSrc.version = "1.2 dummy version";

            return View(supSrc);
        }
    }
}