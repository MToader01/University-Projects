using Proiect3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proiect3.Controllers
{
    public class UserController : Controller
    {
        UserModelDbContext dbCtx = new UserModelDbContext();
        public ActionResult Index()
        {
            return View(dbCtx.Users.ToList());
        }
    }
}