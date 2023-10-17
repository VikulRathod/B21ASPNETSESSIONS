using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// server side code = C# code

namespace WebDotNetApp
{
    public partial class Home : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // setting values on server

            // txtName.Text = "Vihaan";
            txtName.Value = "Vihaan";
            txtEmail.Text = "Vihaan@gmail.com";

            // Response.Write(Application["EventName"]);
            Response.Write("Page_Load event executed <br/>");

            if (Page.IsPostBack)
            {
                Response.Write("POST REQUEST <br/>");
            }
            else
            {
                Response.Write("GET REQUEST <br/>");
            }

        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page_PreInit event executed <br/>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page_Init event executed <br/>");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page_PreRender event executed <br/>");
        }
        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write("Page_PreRenderComplete event executed <br/>");
        }

        protected void Page_Error(object sender, EventArgs e)
        {
            Response.Write("Page_Error event executed <br/>");
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            // last event gets fired when complete page response is created and delivered to browser
            // Response.Write("Page_Error event executed <br/>");
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Response.Write("Button is clicked <br/>");
        }
    }
}