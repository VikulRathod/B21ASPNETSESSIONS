using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3_EFDBFirstAppraoch_CRUD
{
    public partial class StudentDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadStudents();
            }
        }
        void LoadStudents()
        {
            B21DbContext db = new B21DbContext();
            // gvStudents.DataSource = db.Students.ToList();
            gvStudents.DataSource = db.GetStudents().ToList();
            gvStudents.DataBind();
        }

        protected void btnLoadStudent_Click(object sender, EventArgs e)
        {
            int rollNumber = int.Parse(txtRollNumber.Text);
            B21DbContext db = new B21DbContext();
            Student s = db.GetStudentByRollNumber(rollNumber).
                ToList().Single();

            txtName.Text = s.Name;
            // rblGender.SelectedItem.Value = s.Gender;

            foreach (ListItem item in rblGender.Items)
            {
                if(item.Value == s.Gender)
                {
                    item.Selected = true;
                    break;
                }
            }

            txtTrainerId.Text = s.TrainerId.ToString();

            lblMessage.Text = $"Student with roll number {rollNumber} loaded successfully";
        }
    }
}