using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3_EFDBFirstAppraoch_CRUD
{
    public partial class TrainerDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadTrainers();
            }
        }

        void LoadTrainers()
        {
            B21DbContext db = new B21DbContext();
            gvTrainers.DataSource = db.Trainers.ToList();
            gvTrainers.DataBind();
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            int trainerId = int.Parse(txtId.Text);
            B21DbContext db = new B21DbContext();

            Trainer trainer = db.Trainers.FirstOrDefault(t => t.Id == trainerId);

            txtName.Text = trainer.Name;
            txtExperience.Text = trainer.Experience.ToString();
            txtCity.Text = trainer.City;

            lblMessage.Text = $"Trainer details with id {trainerId} loaded successfully";
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            B21DbContext db = new B21DbContext();

            Trainer t = new Trainer() 
            {
            Name = txtName.Text,
            Experience = int.Parse(txtExperience.Text),
            City = txtCity.Text
            };

            db.Trainers.Add(t);

            db.SaveChanges(); // to reflect changes in database

            lblMessage.Text = "New trainer created successfully";

            LoadTrainers(); // to refersh trainer grid

            ClearForm();
        }

        void ClearForm()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtExperience.Text = "";
            txtCity.Text = string.Empty;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int trainerId = int.Parse(txtId.Text);

            B21DbContext db = new B21DbContext();
            Trainer trainer = db.Trainers.FirstOrDefault(t => t.Id == trainerId);

            db.Trainers.Remove(trainer);
            db.SaveChanges();

            lblMessage.Text = $"Trainer with id {trainerId} deleted successfully";

            LoadTrainers(); // to refersh trainer grid

            ClearForm();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int trainerId = int.Parse(txtId.Text);
            string name = txtName.Text;
            int experience = int.Parse(txtExperience.Text);
            string city = txtCity.Text;

            B21DbContext db = new B21DbContext();
            Trainer dbTrainer = db.Trainers.FirstOrDefault(t => t.Id == trainerId);
            dbTrainer.Name = name;
            dbTrainer.Experience = experience;
            dbTrainer.City = city;

            db.SaveChanges();

            lblMessage.Text = $"Trainer with id {trainerId} updated successfully";

            LoadTrainers(); // to refersh trainer grid

            ClearForm();
        }
    }
}