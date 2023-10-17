using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebDotNetApp
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["EventName"] += "Application_Start";
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application["EventName"] += "Session_Start<br/>";
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            Application["EventName"] += "Application_BeginRequest<br/>";
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            Application["EventName"] += "Application_AuthenticateRequest<br/>";
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Application["EventName"] += "Application_Error<br/>";
        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application["EventName"] += "Session_End<br/>";
        }

        protected void Application_End(object sender, EventArgs e)
        {
            Application["EventName"] += "Application_End<br/>";
        }
    }
}