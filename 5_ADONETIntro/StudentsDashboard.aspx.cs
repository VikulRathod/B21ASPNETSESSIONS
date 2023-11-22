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
            //string cs = ConfigurationManager.ConnectionStrings["B21AdoNetDB"].ConnectionString;
            //SqlConnection con = new SqlConnection(cs);

            SqlConnection con = SqlHelper.DbConnection;

            string cmdText = DbConstants.spGetAllStudents;
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            gvStudents.DataSource = reader;
            gvStudents.DataBind();

            con.Close();
        }

        private void LoadTrainers()
        {
            //string cs = ConfigurationManager.ConnectionStrings["B21AdoNetDB"].ConnectionString;
            //SqlConnection con = new SqlConnection(cs);

            SqlConnection con = SqlHelper.DbConnection;

            string cmdText = DbConstants.spAllTrainers;
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

            con.Close();
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            //string cs = ConfigurationManager.ConnectionStrings["B21AdoNetDB"].ConnectionString;
            //SqlConnection con = new SqlConnection(cs);
            SqlConnection con = SqlHelper.DbConnection;

            string cmdText = DbConstants.spCreateStudent;
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
            int rollNumber = !string.IsNullOrEmpty(txtRollNumber.Text) ?
                int.Parse(txtRollNumber.Text) : 0;
            string name = txtName.Text;
            string gender = txtGender.Text;
            string city = txtCity.Text;
            int trainerId = int.Parse(ddlTrainer.SelectedValue);

            //string cs = ConfigurationManager.ConnectionStrings["B21AdoNetDB"].ConnectionString;
            //SqlConnection con = new SqlConnection(cs);
            SqlConnection con = SqlHelper.DbConnection;

            string cmdText = DbConstants.spUpdateStudent;
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@RollNumber", rollNumber);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@City", city);
            cmd.Parameters.AddWithValue("@TrainerId", trainerId);

            SqlParameter status = new SqlParameter();
            status.ParameterName = "@Status";
            status.Direction = ParameterDirection.Output;
            status.SqlDbType = SqlDbType.Bit;
            cmd.Parameters.Add(status);

            con.Open();

            int result = cmd.ExecuteNonQuery();

            bool output = (bool) status.Value;
            if (output)
            {
                ClearFields();
                lblMessage.Text = "Student Details Updated Successfully";
                LoadStudents();
            }
            else
            {
                lblMessage.Text = "Student Details Update Failed";
            }
            con.Close();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int rollNumber = !string.IsNullOrEmpty(txtRollNumber.Text) ?
                int.Parse(txtRollNumber.Text) : 0;

            //string cs = ConfigurationManager.ConnectionStrings["B21AdoNetDB"].ConnectionString;
            //SqlConnection con = new SqlConnection(cs);
            SqlConnection con = SqlHelper.DbConnection;

            string cmdText = DbConstants.spDeleteStudent;
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@RollNumber", rollNumber);

            SqlParameter status = new SqlParameter();
            status.ParameterName = "@Status";
            status.Direction = ParameterDirection.Output;
            status.SqlDbType = SqlDbType.Bit;
            cmd.Parameters.Add(status);

            con.Open();

            int result = cmd.ExecuteNonQuery();

            bool output = (bool)status.Value;
            if (output)
            {
                ClearFields();
                lblMessage.Text = "Student Deleted Successfully";
                LoadStudents();
            }
            else
            {
                lblMessage.Text = "Student Delete Failed";
            }
            con.Close();
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
            // ddlTrainer.SelectedItem.Value = "-1";
            ddlTrainer.SelectedValue = "-1";
            lblMessage.Text = string.Empty;
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            //string cs = ConfigurationManager.ConnectionStrings["B21AdoNetDB"].ConnectionString;
            //SqlConnection con = new SqlConnection(cs);
            SqlConnection con = SqlHelper.DbConnection;

            string cmdText = DbConstants.spGetStudentDetailsByRollNumber;
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
            con.Close();
        }
    }
}