﻿using _4_CRUDUsingEF.Utility;
using System.Web;
using System.Web.Mvc;

namespace _4_CRUDUsingEF
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // filters.Add(new HandleErrorAttribute());
            // filters.Add(new AuthorizeAttribute()); // global level

            filters.Add(new CustomActionFilterAttribute());
        }
    }
}
