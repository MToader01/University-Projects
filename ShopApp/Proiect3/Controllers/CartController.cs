using Proiect3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proiect3.Controllers
{
    public class CartController : Controller
    {
        public ActionResult Index()
        {
            TraceHandler.write("Cart Index View Called");
            return View(Cart.cart);
        }
        public ActionResult Clear()
        {
            Cart.resetCart();
            return RedirectToAction("Index", "Cart");
        }

        public ActionResult Buy()
        {
            TraceHandler.write("Cart buyed");
            Cart.resetCart();
            Cart.dbCtx.SaveChanges();

            return RedirectToAction("Index", "Shop");
        }
    }
}