using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_CRUDUsingEF.Utility
{
    public class CustomActionFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(
            ActionExecutingContext filterContext)
        {
            string controllerName =
                filterContext.RouteData.Values["controller"].ToString();
            string actionName =
                filterContext.RouteData.Values["action"].ToString();
            string currentTime = DateTime.Now.ToString();

            Log($"OnActionExecuting : {controllerName} {actionName} at {currentTime}");

            // base.OnActionExecuting(filterContext);
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            string controllerName =
                filterContext.RouteData.Values["controller"].ToString();
            string actionName =
                filterContext.RouteData.Values["action"].ToString();
            string currentTime = DateTime.Now.ToString();

            Log($"OnActionExecuted : {controllerName} {actionName} at {currentTime}");
            // base.OnActionExecuted(filterContext);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            string controllerName =
                filterContext.RouteData.Values["controller"].ToString();
            string actionName =
                filterContext.RouteData.Values["action"].ToString();
            string currentTime = DateTime.Now.ToString();

            Log($"OnResultExecuting : {controllerName} {actionName} at {currentTime}");

            // base.OnResultExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            string controllerName =
                filterContext.RouteData.Values["controller"].ToString();
            string actionName =
                filterContext.RouteData.Values["action"].ToString();
            string currentTime = DateTime.Now.ToString();

            Log($"OnResultExecuted : {controllerName} {actionName} at {currentTime}");

            // base.OnResultExecuted(filterContext);
        }

        private void Log(string message)
        {
           string filePath =
                HttpContext.Current.Server.MapPath(@"~\Data\Log.txt");

            File.AppendAllText(filePath, $"{message}\n");
            File.AppendAllText(filePath, $"********************************************\n");
        }

    }
}