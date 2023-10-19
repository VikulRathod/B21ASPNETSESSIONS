using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebDotNetApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void cbAction_CheckedChanged(object sender, EventArgs e)
        {
            string pwd = txtPassword.Text;
            txtPassword.Attributes.Remove("type");
            if (cbAction.Checked)
            {
                // txtPassword.Attributes.Add("type", "text");
                txtPassword.Attributes.Add("value", pwd);
                txtPassword.TextMode = TextBoxMode.SingleLine;
                //txtPassword.Text = pwd;
            }
            else
            {
                // txtPassword.Attributes.Add("type", "password");
                txtPassword.Attributes.Add("value", pwd);
                //txtPassword.Text = pwd;
                txtPassword.TextMode = TextBoxMode.Password;
            }
        }

        protected void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            lblEmail.Text = "";

            if (email.Length < 5)
            {
                lblEmail.Text = "INVALID EMAIL";
            }
        }
    }
}