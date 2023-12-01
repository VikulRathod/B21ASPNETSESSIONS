using EFCodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EFCodeFirstApproach
{
    public partial class TrainerDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadTrainers();
            }
        }

        void LoadTrainers()
        {
            B21CodeFirstDBContext db = new B21CodeFirstDBContext();
            gvTrainers.DataSource =  db.Trainers.ToList();
            gvTrainers.DataBind();
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            B21CodeFirstDBContext db = new B21CodeFirstDBContext();
            Trainer trainer = new Trainer() 
            {
            Name = txtName.Text,
            Experience = int.Parse(txtExperience.Text)
            };

            db.Trainers.Add(trainer);
            db.SaveChanges();

            lblMessage.Text = "Trainer Created Successfully";

            LoadTrainers(); // trainers list refresh
        }
    }
}