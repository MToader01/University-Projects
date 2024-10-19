using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Languages2;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
using System.Xml.Linq;

namespace Proiect3.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        [Display(Name = "Name", ResourceType = typeof(Resource))]
        public string Name { get; set; }
        [Display(Name = "Description", ResourceType = typeof(Resource))]
        public string Description { get; set; }
        [Display(Name = "AddedDate", ResourceType = typeof(Resource))]
        public DateTime AddedDate { get; set; }
        [Display(Name = "ExpirationDate", ResourceType = typeof(Resource))]
        public DateTime ExpirationDate { get; set; }
        [Display(Name = "Quantity", ResourceType = typeof(Resource))]
        public int Quantity { get; set; }
    }

    public class ProductModelDbContext : DbContext
    {
        public DbSet<ProductModel> Products { get; set; }
    }
}