using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataTransferTechniques
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        public string UserControlTextBox
        {
            get
            {
                return txtUC.Text;
            }
            set
            {
                txtUC.Text = value;
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUC_Click(object sender, EventArgs e)
        {
            string data = txtUC.Text;

            var page = (Create)Page;

            //var control = page.FindControl("txtWebForm");
            //TextBox pageTextBox = (TextBox) control;

            page.PageTextBox = data;

            var master = (MySiteMaster)Page.Master;
            master.MasterTextBox = data;
        }
    }
}