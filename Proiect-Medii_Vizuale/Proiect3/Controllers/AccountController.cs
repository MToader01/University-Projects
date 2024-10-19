using Proiect3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace Proiect3.Controllers
{
    public class AccountController : Controller
    {
        UserModelDbContext dbContext = new UserModelDbContext();

        [HttpGet]
        public ActionResult Login()
        {
            TraceHandler.write("Login View Called");
            if (LoginState.isLoggedIn == true)
            {
                //Pagina user
                return RedirectToAction("UserPanel", "Account");
            }
            else
            {
                //Pagina login
                LoginModel model = new LoginModel();
                return View(model);
            }
            
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            using (UserModelDbContext ut = new UserModelDbContext())
            {
                var rez = from s in ut.Users
                          where s.Username.Equals(model.Username)
                          select new
                          {
                              s.Id,
                              s.Username,
                              s.Password,
                              s.IsAdmin
                          };

                if (rez.Count() != 0)
                {
                    if (rez.First().Password == model.Password)
                    {
                        if (rez.First().IsAdmin == true)
                            LoginState.isAdmin = true;
                        else
                            LoginState.isAdmin = false;

                        LoginState.Id = rez.First().Id;
                        LoginState.Username = rez.First().Username;
                        TraceHandler.write("Login succesful");
                        LoginState.isLoggedIn = true;
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    return View(model);
                }
            }
            return View(model);
        }

        public ActionResult Register()
        {
            TraceHandler.write("Register View Called");
            UserModel user = new UserModel();
            return View(user);
        }

        [HttpPost]
        public ActionResult Register(UserModel user)
        {
            TraceHandler.write("Account created");
            if (user.FirstName == null || user.LastName == null || user.Password == null || user.Username == null)
            {
                TraceHandler.write("Completati toate campurile");
                return RedirectToAction("Register", "Account");
            }
            else
            {
                var rez = from s in dbContext.Users
                          where s.Username.Equals(user.Username)
                          select new
                          {
                              s.Id,
                              s.Username,
                              s.Password,
                              s.IsAdmin
                          };
                if(rez.Count() == 0)
                {
                    //Utilizatorul nu exista - se creeaza
                    dbContext.Users.Add(user);
                    dbContext.SaveChanges();
                }
                else
                {
                    //username existent
                    TraceHandler.write("Completati toate campurile");
                    return RedirectToAction("Register", "Account");
                }

                
            }
            
            return RedirectToAction("Login", "Account");
        }

        public ActionResult UserPanel()
        {
            TraceHandler.write("UserPanel View Called");
            UserModel user = new UserModel();
            return View(user);
        }

        public ActionResult Disconnect()
        {
            TraceHandler.write("Account disconnected");
            LoginState.isAdmin = false;
            LoginState.isLoggedIn = false;
            LoginState.Username = null;

            return RedirectToAction("Index", "Home");
        }
        
    }
}