using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataTransferTechniques
{
    public partial class Views : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Application["total"] != null)
            {
                int counter = (int) Application["total"];
                counter++;
                Application["total"] = counter;
            }

            lblTotalViews.Text = Application["total"]?.ToString();
            lblUniqueViews.Text = Application["unique"]?.ToString();
        }
    }
}