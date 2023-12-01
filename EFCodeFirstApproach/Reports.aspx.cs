using EFCodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EFCodeFirstApproach
{
    public partial class Reports : System.Web.UI.Page
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
            B21CodeFirstDBContext db = new B21CodeFirstDBContext();
            //gvStudents.DataSource = db.Students.ToList();
            //gvStudents.DataBind();

            var result = (from s in db.Students
                         join t in db.Trainers
                         on s.TrainerId equals t.Id
                         into temp
                         from trainer in temp.DefaultIfEmpty()
                         select new
                         {
                             RollNumber = s.RollNumber,
                             StudentName = s.Name,
                             StudentGender = s.Gender,
                             TrainerId = trainer != null ? trainer.Id : 0,
                             TrainerName = trainer != null ? trainer.Name : "",
                             TrainerExp = trainer != null ? trainer.Experience : 0
                         }).ToList();

            gvStudents.DataSource = result;
            gvStudents.DataBind();
        }
    }
}