using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_CRUDUsingEF.Utility
{
    //public class CustomHandleErrorAttribute : IExceptionFilter
    //{
    //    public void OnException(ExceptionContext filterContext)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    public class CustomHandleErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            string error = filterContext.Exception.Message;
            string controllerName =
                filterContext.RouteData.Values["controller"].ToString();
            string actionName =
                filterContext.RouteData.Values["action"].ToString();

            // we can store this error information in database

            filterContext.ExceptionHandled = true;

            filterContext.Result = new ViewResult()
            {
                ViewName = "CustomErrorPage"
            };
        }
    }
}