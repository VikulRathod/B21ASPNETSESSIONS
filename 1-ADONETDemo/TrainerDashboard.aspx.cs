using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_ADONETDemo
{
    public partial class TrainerDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // ado.net code
            string cs = ConfigurationManager.ConnectionStrings["B21EFDB"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("select Id, Name, Experience from Trainer", con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            // reader => list
            List<Trainer> trainers = new List<Trainer>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Trainer t = new Trainer();
                    t.Id = (int) reader["Id"];
                    t.Name = reader["Name"].ToString();
                    t.Experience = (int)reader["Experience"];

                    trainers.Add(t);
                }
            }

            con.Close();

            gvTrainers.DataSource = trainers;
            gvTrainers.DataBind();
        }
    }
}