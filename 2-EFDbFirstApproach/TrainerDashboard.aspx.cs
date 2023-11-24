using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_EFDbFirstApproach
{
    public partial class TrainerDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            B21EFDBConnection db = new B21EFDBConnection();
            // ef code
            gvTrainers.DataSource = db.Trainers.ToList();
            gvTrainers.DataBind();
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            B21EFDBConnection db = new B21EFDBConnection();
            int id = int.Parse(txtId.Text);

            var filtered = db.Trainers.Where(t => t.Id == id).ToList();

            gvTrainers.DataSource = filtered;
            gvTrainers.DataBind();
        }
    }
}