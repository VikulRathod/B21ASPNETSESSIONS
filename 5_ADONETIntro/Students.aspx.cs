using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace _5_ADONETIntro
{
    public partial class Students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadStudents();
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

            string connectionString =
                "server=.\\sqlexpress;database=B21AdoNetDb;integrated security=true;";

            SqlConnection con = new SqlConnection(connectionString);
            // con.ConnectionString = connectionString;

            con.Open();

            string cmdText =
                "select RollNumber, Name, Gender, City from Student";
            SqlCommand cmd = new SqlCommand(cmdText, con);

            SqlDataReader reader = cmd.ExecuteReader();

            gvStudents.DataSource = reader;
            gvStudents.DataBind();

            con.Close();
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text;

            string cs = "server=.\\sqlexpress;database=B21AdoNetDb;integrated security=true;";
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