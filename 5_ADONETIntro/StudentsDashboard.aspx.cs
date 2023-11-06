using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace _5_ADONETIntro
{
    public partial class StudentsDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadStudents();
                LoadTrainers();
            }
        }

        private void LoadStudents()
        {
            string cs = ConfigurationManager.ConnectionStrings["B21AdoNetDB"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);

            string cmdText = "usp_GetAllStudents";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            gvStudents.DataSource = reader;
            gvStudents.DataBind();
        }

        private void LoadTrainers()
        {
            string cs = ConfigurationManager.ConnectionStrings["B21AdoNetDB"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);

            string cmdText = "usp_AllTrainers";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            ddlTrainer.DataValueField = "Id";
            ddlTrainer.DataTextField = "Name";

            ddlTrainer.DataSource = reader;
            ddlTrainer.DataBind();

            ListItem li = new ListItem("-- Select Trainer --", "-1");
            ddlTrainer.Items.Insert(0, li);
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["B21AdoNetDB"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);

            string cmdText = "usp_CreateStudent";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
            cmd.Parameters.AddWithValue("@City", txtCity.Text);
            cmd.Parameters.AddWithValue("@TrainerId", ddlTrainer.SelectedValue);

            SqlParameter status = new SqlParameter();
            status.ParameterName = "@Status";
            status.Direction = ParameterDirection.Output;
            status.SqlDbType = SqlDbType.Bit;

            cmd.Parameters.Add(status);

            con.Open();

            int rowsAffected = cmd.ExecuteNonQuery();

            bool result = (bool) status.Value;
            if (result)
            {                
                ClearFields();
                LoadStudents();
                lblMessage.Text = "Student Insert Success";               
            }
            else
            {
                lblMessage.Text = "Student Insert Failed";
            }

            con.Close();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtRollNumber.Text = string.Empty; // ""
            txtName.Text = string.Empty;
            txtGender.Text = string.Empty;
            txtCity.Text = string.Empty;
            // txtTrainerId.Text = string.Empty;
            ddlTrainer.SelectedItem.Value = "-1";
            lblMessage.Text = string.Empty;
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["B21AdoNetDB"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);

            string cmdText = "usp_GetStudentDetailsByRollNumber";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.CommandType = CommandType.StoredProcedure;

            int rollNumber = !string.IsNullOrEmpty(txtRollNumber.Text) ?
                int.Parse(txtRollNumber.Text) : 0;

            cmd.Parameters.AddWithValue("@RollNumber", rollNumber);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    txtName.Text = reader["Name"].ToString();
                    txtGender.Text = reader["Gender"].ToString();
                    txtCity.Text = reader["City"].ToString();
                    // txtTrainerId.Text = reader["TrainerId"].ToString();
                    string trainerId = reader["TrainerId"].ToString();
                    // ddlTrainer.SelectedItem.Value = trainerId;
                    ddlTrainer.SelectedValue = trainerId;
                }
                lblMessage.Text = "Student Loaded Successfully.";
            }
            else
            {
                lblMessage.Text = "No Student Found For Given Roll Number.";
            }
        }
    }
}