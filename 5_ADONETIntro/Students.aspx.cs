using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using _5_ADONETIntro.Modals;
using System.Reflection.Emit;
using System.Data;
using System.Configuration;

namespace _5_ADONETIntro
{
    public partial class Students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // LoadStudents();
                LoadDataUsingAdapter();
            }
        }

        private void LoadStudents()
        {
            //string connectionString =
            //    "server=.\\sqlexpress;database=B21AdoNetDb;integrated security=true;";

            //string connectionString =
            //    "data source=.\\sqlexpress;initial catalog=B21AdoNetDb;integrated security=true;";

            //string connectionString =
            //    "server=.\\sqlexpress;database=B21AdoNetDb;user id=user;password=123456;";

            //string connectionString =
            //    "server=.\\sqlexpress;database=B21AdoNetDb;integrated security=true;";

            string connectionString = ConfigurationManager.
                ConnectionStrings["B21AdoNetDB"].
                ConnectionString;

            SqlConnection con = new SqlConnection(connectionString);
            // con.ConnectionString = connectionString;

            con.Open();

            string cmdText =
                "select RollNumber, Name, Gender, City, TrainerId from Student;select * from Trainer";
            SqlCommand cmd = new SqlCommand(cmdText, con);

            SqlDataReader reader = cmd.ExecuteReader();

            //gvStudents.DataSource = reader;
            //gvStudents.DataBind();

            // convert reader object to list and then bind list to gridview
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                Student s = new Student();
                s.RollNumber = (int)reader["RollNumber"];
                s.Name = reader["Name"].ToString();
                s.Gender = reader["Gender"].ToString();
                s.City = reader["City"].ToString();
                s.TrainerId = (int)reader["TrainerId"];

                students.Add(s);
            }

            gvStudents.DataSource = students;
            gvStudents.DataBind();

            if (reader.NextResult())
            {
                gvTrainers.DataSource = reader;
                gvTrainers.DataBind();
            }

            con.Close();
        }

        private void LoadDataUsingAdapter()
        {
            // string cs = "server=.\\sqlexpress;database=B21AdoNetDb;integrated security=true;";
            string cs = ConfigurationManager.ConnectionStrings["B21AdoNetDB"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);

            string cmdText = "select * from Student;select * from Trainer;";
            SqlDataAdapter adapter = new SqlDataAdapter(cmdText, con);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            gvStudents.DataSource = ds.Tables[0];
            gvStudents.DataBind();

            gvTrainers.DataSource = ds.Tables[1];
            gvTrainers.DataBind();
        }


        protected void btnLoad_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text;

            // string cs = "server=.\\sqlexpress;database=B21AdoNetDb;integrated security=true;";
            string cs = ConfigurationManager.ConnectionStrings["B21AdoNetDB"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            // string cmdText = $"select RollNumber, Name, Gender, City from Student where City = '{city}'";

            string cmdText = $"select RollNumber, Name, Gender, City from Student where City = @City";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@City", city);

            SqlDataReader reader = cmd.ExecuteReader();

            gvStudents.DataSource = reader;
            gvStudents.DataBind();

            con.Close();
        }
    }
}