using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataTransferTechniques
{
    public partial class MySiteMaster : System.Web.UI.MasterPage
    {
        public string MasterTextBox
        {
            get
            {
                return txtMaster.Text;
            }
            set
            {
                txtMaster.Text = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMaster_Click(object sender, EventArgs e)
        {

        }
    }
}