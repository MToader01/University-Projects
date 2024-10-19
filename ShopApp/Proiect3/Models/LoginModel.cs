using Languages2;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Proiect3.Models
{
    public class LoginModel
    {
        [Required]
        [Display(Name = "Username", ResourceType = typeof(Resource))]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password", ResourceType = typeof(Resource))]
        public string Password { get; set; }
    }
}