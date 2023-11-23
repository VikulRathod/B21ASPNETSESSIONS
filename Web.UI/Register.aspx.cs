using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Unity;

namespace Web.UI
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            User user = new User()
            {
                Name = name,
                Email = email,
                Password = password
            };

            // UsersBL bl = new UsersBL();

            IUnityContainer unity = (UnityContainer)Application["unity"];
            UsersBL bl = unity.Resolve<UsersBL>();

            int regNo;
            bool result = bl.Insert(user, out regNo);

            if (result)
            {
                lblMessage.Text = $"Registration Successful. Your Registration Number is {regNo}";
            }
            else
            {
                lblMessage.Text = "Registration Failed";
            }
        }
    }
}