using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VCart.BLL.Interfaces;

namespace VCart.Web.Controllers
{
    [Authorize(Roles = "Admin, Merchant")]
    public class UsersController : Controller
    {
        IUserBL _bl = null;

        public UsersController(IUserBL bl)
        {
            _bl = bl;
        }

        // GET: Users
        public ActionResult Index()
        {
            var users = _bl.AllUsers();
            return View(users);
        }
    }
}