using Proiect3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Web.UI;

namespace Proiect3.Controllers
{
    public class ShopController : Controller
    {
        public ProductModelDbContext dbCtx = new ProductModelDbContext();
        public ActionResult Index()
        {
            TraceHandler.write("Shop Index View Called");
            return View(dbCtx.Products.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            TraceHandler.write("Create View Called");
            ProductModel product = new ProductModel();
            return View(product);
        }

        [HttpPost]
        public ActionResult Create(ProductModel product)
        {
            TraceHandler.write("Added New Item");
            dbCtx.Products.Add(product);
            dbCtx.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            TraceHandler.write("Details View Called");
            if (id != null)
            {
                ProductModel product = dbCtx.Products.Find(id);
                return View(product);
            }
            else return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            TraceHandler.write("Edit View Called");
            if (id != null)
            {
                ProductModel product = dbCtx.Products.Find(id);
                return View(product);
            }
            else return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(ProductModel product)
        {
            TraceHandler.write("Product edited");
            dbCtx.Products.AddOrUpdate(product);
            dbCtx.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            TraceHandler.write("Delete View Called");
            if (id != null)
            {
                ProductModel product = dbCtx.Products.Find(id);
                return View(product);
            }
            else return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(ProductModel product)
        {
            TraceHandler.write("Product Deleted");
            dbCtx.Entry(product).State = System.Data.Entity.EntityState.Deleted;
            dbCtx.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Buy(int? id)
        {
            if (id != null)
            {
                var rez = from s in dbCtx.Products
                          where s.Id == id
                          select new
                          {
                              s.Name,
                              s.Description,
                              s.Quantity,
                              s.AddedDate,
                              s.ExpirationDate
                          };

                if (rez.Count() == 1)
                {
                    Cart.newProduct.Name = rez.First().Name;
                    Cart.newProduct.Quantity = rez.First().Quantity;
                    Cart.newProduct.Description = rez.First().Description;
                    Cart.newProduct.ExpirationDate = rez.First().ExpirationDate;
                    Cart.newProduct.AddedDate = rez.First().AddedDate;
                }
                Trace.WriteLine(Cart.newProduct.Name);
                return View(Cart.newProduct);
            }
            else return RedirectToAction("Index");
        }
                                                                                  
        [HttpPost]                                                                
        public ActionResult Buy(ProductModel product, int? id)                             
        {
            Cart.dbCtx = dbCtx;

            ProductModel p = dbCtx.Products.Find(id);

            if (product.Quantity > p.Quantity)
            {
                return View(Cart.newProduct);
            }
            else
            {
                Cart.newProduct.Quantity = product.Quantity;
                Cart.addToCart();

                p.Quantity -= product.Quantity;
                if(p.Quantity == 0) 
                {
                    dbCtx.Entry(dbCtx.Products.Find(id)).State = System.Data.Entity.EntityState.Deleted;
                }
                else
                {
                    dbCtx.Entry(dbCtx.Products.Find(id)).State = System.Data.Entity.EntityState.Modified;
                }
            }

            return RedirectToAction("Index");
        }
    }
}