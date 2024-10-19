using Proiect3.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Proiect3
{
    public class Cart
    {
        public static ProductModelDbContext dbCtx = new ProductModelDbContext();
        public static ProductModel newProduct = new ProductModel();

        public static List<ProductModel> cart = new List<ProductModel>();

        public static void resetCart()
        {
            cart.Clear();
        }

        public static void addToCart()
        {
            cart.Add(newProduct);
            newProduct = new ProductModel();
        }

        public static void removeFromCart(ProductModel product)
        {
            cart.Remove(product);
        }
    }
}