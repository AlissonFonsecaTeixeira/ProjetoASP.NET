﻿using Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projetoASP.NET.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ModelSistema>());
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}