using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proiect3
{
    public static class LoginState
    {
        public static bool isLoggedIn { get; set; }
        public static bool isAdmin { get; set; }
        public static int Id { get; set; }
        public static string Username { get; set; }
    }
}