using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataTransferTechniques
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // reading query string values
                //if (Request.QueryString["name"] != null)
                //{
                //    lblName.Text = Request.QueryString["name"];
                //}
                //if (Request.QueryString["email"] != null)
                //{
                //    lblEmail.Text = Request.QueryString["email"];
                //}

                // reading from cookies
                //HttpCookie user = Request.Cookies["b21UserData"];
                //if(user != null)
                //{
                //    lblName.Text = user["name"];
                //    lblEmail.Text = user["email"];
                //}

                // reading from session
                //if (Session["name"] != null)
                //{
                //    lblName.Text = Session["name"].ToString();
                //}
                //if (Session["email"] != null)
                //{
                //    lblEmail.Text = Session["email"].ToString();
                //}

                // reading from application
                if (Application["name"] != null)
                {
                    lblName.Text = Application["name"].ToString();
                }
                if (Application["email"] != null)
                {
                    lblEmail.Text = Application["email"].ToString();
                }
            }
        }

        protected void btnRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm1.aspx");
        }
    }
}