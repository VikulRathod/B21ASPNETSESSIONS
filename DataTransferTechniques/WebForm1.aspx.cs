using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataTransferTechniques
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRedirect_Click(object sender, EventArgs e)
        {
            // redirect or navigate Webform2 page

            // using query string
            //string name = HttpUtility.UrlEncode(txtName.Text);
            //string email = HttpUtility.UrlEncode(txtEmail.Text);

            //string url = $"~/WebForm2.aspx?name={name}&email={email}";
            //Response.Redirect(url);

            // Response.Redirect("~/WebForm2.aspx?name=" + txtName.Text + "&email=" + txtEmail.Text); // within same server

            //// using cookie
            //string name = txtName.Text;
            //string email = txtEmail.Text;

            //HttpCookie user = new HttpCookie("b21UserData");
            //user["name"] = name;
            //user["email"] = email;

            //// persistent cookie
            //user.Expires.AddDays(1); // cookie will be there for entire day

            //Response.Cookies.Add(user);

            string name = txtName.Text;
            string email = txtEmail.Text;

            //Session["name"] = name;
            //Session["email"] = email;   

            Application["name"] = name;
            Application["email"] = email;

            Response.Redirect("~/WebForm2.aspx");
        }

        protected void btnGoogle_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://www.google.com"); // another server
        }
    }
}