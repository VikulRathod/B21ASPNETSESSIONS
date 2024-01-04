using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using VCart.BLL.Interfaces;
using VCart.Models;

namespace VCart.Web.Controllers
{
    public class AccountController : Controller
    {
        IUserBL _bl = null;

        public AccountController(IUserBL bl)
        {
            _bl = bl;
        }

        // GET: Account
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                bool status = _bl.CreateUser(user);
                if (status)
                {
                    return RedirectToAction("Login");
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string Email, string Password)
        {
            var user = _bl.AuthenticateUser(Email, Password);

            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.Email, false);
                
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("Email", "User does not exists");
            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Login");
        }
    }
}