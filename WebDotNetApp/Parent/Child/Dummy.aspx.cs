using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebDotNetApp.Parent.Child
{
    public partial class Dummy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rootFolder = Server.MapPath("~/");
            string parentFolder = Server.MapPath("../");
            string currentFolder = Server.MapPath("./");


            Response.Write($"Root Directory Path: {rootFolder} <br/>");
            Response.Write($"Parent Directory Path: {parentFolder} <br/>");
            Response.Write($"Current Directory Path: {currentFolder} <br/>");
        }
    }
}