using Functionality.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Functionality.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User obj)
        {
            if (ModelState.IsValid)
            {
                using (var context = new CustomerContext())
                {
                    context.Users.Add(obj);
                    context.SaveChanges();
                }
            }
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User obj)
        {
            if (ModelState.IsValid)
            {
                using (var context = new CustomerContext())
                {
                    var check = context.Users.FirstOrDefault(u => u.Email == obj.Email && u.password == obj.password);
                    if (check != null)
                    {
                        Session["User"] = obj.Email.ToString();
                        RedirectToAction("Index", "Customer");
                    }
                    else
                    {
                        RedirectToAction("Login");
                    }
                }
            }
            ModelState.AddModelError("", "invalid Username or Password");
            return View();
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return View();  
        }
    }
}