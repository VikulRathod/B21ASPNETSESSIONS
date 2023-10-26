using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataTransferTechniques
{
    public partial class CalculatorPage : System.Web.UI.Page
    {
        // int _counter = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // txtNumber.Text = _counter.ToString();
                // txtNumber.Text = hiddenNumber.Value;
                ViewState["number"] = 1;
                txtNumber.Text = ViewState["number"].ToString();
            }
        }

        protected void btnIncrement_Click(object sender, EventArgs e)
        {
            //_counter++;
            //txtNumber.Text = _counter.ToString();

            //int num = int.Parse(hiddenNumber.Value);
            //num++;
            //hiddenNumber.Value = num.ToString();
            //txtNumber.Text = num.ToString();

            int num = (int)ViewState["number"];
            num++;
            ViewState["number"] = num;
            txtNumber.Text = num.ToString();
        }
    }
}