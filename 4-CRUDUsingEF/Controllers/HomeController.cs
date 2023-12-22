using _4_CRUDUsingEF.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_CRUDUsingEF.Controllers
{
    public class HomeController : Controller
    {
        // [AllowAnonymous]
        // [RequireHttps]
        // [OutputCache(Duration = 30)]
        // [OutputCache(CacheProfile = "5MinutesCache")]
        // [HandleError]
        // [CustomHandleErrorAttribute]
        public ActionResult Index()
        {
            //int a = 10, b = 0;
            //int c = a / b;

            ViewBag.LoadedTime = DateTime.Now.ToString();

            return View();

            #region using try catch
            //try
            //{
            //    int a = 10, b = 0;
            //    int c = a / b;

            //    ViewBag.LoadedTime = DateTime.Now.ToString();

            //    return View();
            //}
            //catch
            //{
            //    return View();
            //}
            #endregion using try catch
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ChildActionOnly]
        public PartialViewResult PartialViewContent()
        {
            return PartialView("_PartialView");
        }
    }
}