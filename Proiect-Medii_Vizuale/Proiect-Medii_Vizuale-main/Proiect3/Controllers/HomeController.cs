using Proiect3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Diagnostics;
using Microsoft.Ajax.Utilities;

namespace Proiect3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login() 
        {
            Trace.WriteLine("Login Page deschis");
            return RedirectToAction("Login", "Account");
        }
        public ActionResult Index()
        {
            
            if (TraceHandler.isActive == false)
            {
                TraceHandler.Initialization();
            }

            TraceHandler.write("Home Index View Called");
            return View();
        }

        public ActionResult About()
        {
            TraceHandler.write("About View Called");
            ViewBag.Message = "Your application description page.";

            return View();
        }
        
        public ActionResult ChangeLanguage(string lang)
        {
            TraceHandler.write("Language Changed To "  + lang);

            Session["lang"] = lang;
            
            return RedirectToAction("Index", "Home",
                new { language = lang });
        }

    }
}