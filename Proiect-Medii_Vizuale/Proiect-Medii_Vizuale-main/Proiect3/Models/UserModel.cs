using Languages2;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Xml.Linq;

namespace Proiect3.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        [Display(Name = "FirstName", ResourceType = typeof(Resource))]
        public string FirstName { get; set; }
        [Display(Name = "LastName", ResourceType = typeof(Resource))]
        public string LastName { get; set; }
        [Display(Name = "Username", ResourceType = typeof(Resource))]
        public string Username { get; set; }
        [Display(Name = "Password", ResourceType = typeof(Resource))]
        public string Password { get; set; }
        [Display(Name = "IsAdmin", ResourceType = typeof(Resource))]
        public bool IsAdmin { get; set; }
    }

    public class UserModelDbContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
    }
}