using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataTransferTechniques
{
    public partial class Create : System.Web.UI.Page
    {
        public string PageTextBox
        {
            get
            {
                return txtWebForm.Text;
            }
            set
            {
                txtWebForm.Text = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnWebForm_Click(object sender, EventArgs e)
        {
            string val = txtWebForm.Text;

            myUserControl1.UserControlTextBox = val;
            ((MySiteMaster)Master).MasterTextBox = val;
        }
    }
}