﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class onlyIdController : Controller
    {
        // GET: onlyId
        public ActionResult Get()
        {
            // insert a little dummy data 
            // class data fields are public modiffiers you can access them here.
            onlyId onlid = new onlyId();
            onlid.id = "Only id example";
            return View(onlid);
        }
    }
}