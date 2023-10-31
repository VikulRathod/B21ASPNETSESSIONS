using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataTransferTechniques
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (Page.IsValid) // true only if all page validations are success
            {
                Response.Write($"Validation Success <br/>");
            }
            else
            {
                Response.Write($"Validation Failed <br/>");
            }
        }

        protected void CustomValidator1_ServerValidate(object source, 
            ServerValidateEventArgs args)
        {
            // 1. making input mandatory
            // 2. checking whether input is even or not

            string input = args.Value;
            if (!string.IsNullOrEmpty(input))
            {
                int number;
                if(int.TryParse(input, out number))
                {
                    if(number % 2 == 0)
                    {
                        args.IsValid = true;
                    }
                    else
                    {
                        args.IsValid = false;
                    }
                }
                else
                {
                    args.IsValid = false;
                }
            }
            else
            {
                args.IsValid = false; // mandatory
            }

        }
    }
}