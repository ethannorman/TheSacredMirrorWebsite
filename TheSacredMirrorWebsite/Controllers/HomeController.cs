﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheSacredMirrorWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Grimoire()
        {

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Me:";

            return View();
        }

    }
}
