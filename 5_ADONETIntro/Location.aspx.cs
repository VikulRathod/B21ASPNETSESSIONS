using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5_ADONETIntro
{
    public partial class Location : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCountries();

                //Customer c1 = new Customer();

                //using (Customer c2 = new Customer())
                //{

                //}
            }
        }

        //private void LoadCountries()
        //{
        //    string cs = ConfigurationManager.ConnectionStrings["B21AdoNetDB"].ConnectionString;
        //    SqlConnection con = new SqlConnection(cs);

        //    SqlCommand cmd = new SqlCommand("usp_AllCountries", con);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    con.Open();
        //    SqlDataReader reader = cmd.ExecuteReader();

        //    ddlCountry.DataValueField = "Id";
        //    ddlCountry.DataTextField = "Name";
        //    ddlCountry.DataSource = reader;
        //    ddlCountry.DataBind();

        //    ListItem li = new ListItem("-- Select Country --", "-1");
        //    ddlCountry.Items.Insert(0, li);

        //    con.Close();
        //}

        //private void LoadCountries()
        //{
        //    SqlConnection con = null;
        //    try
        //    {
        //        string cs = ConfigurationManager.ConnectionStrings["B21AdoNetDB"].ConnectionString;
        //        con = new SqlConnection(cs);

        //        SqlCommand cmd = new SqlCommand("usp_AllCountries", con);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        con.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();

        //        ddlCountry.DataValueField = "Id";
        //        ddlCountry.DataTextField = "Name";
        //        ddlCountry.DataSource = reader;
        //        ddlCountry.DataBind();

        //        ListItem li = new ListItem("-- Select Country --", "-1");
        //        ddlCountry.Items.Insert(0, li);

        //        //con.Close();
        //    }
        //    //catch (Exception ex)
        //    //{
        //    //    ListItem li = new ListItem("-- No Country --", "-1");
        //    //    ddlCountry.Items.Insert(0, li);
        //    //}
        //    finally
        //    {
        //        if (con != null)
        //        {
        //            con.Close();
        //        }
        //    }
        //}

        private void LoadCountries()
        {
            string cs = ConfigurationManager.ConnectionStrings["B21AdoNetDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs)) 
            {
                SqlCommand cmd = new SqlCommand("usp_AllCountries", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                ddlCountry.DataValueField = "Id";
                ddlCountry.DataTextField = "Name";
                ddlCountry.DataSource = reader;
                ddlCountry.DataBind();

                ListItem li = new ListItem("-- Select Country --", "-1");
                ddlCountry.Items.Insert(0, li);

                // con.Dispose(); // 1. closes connection 2. deallocate object
            }
        }

        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            // fetch all states by selected country
            int countryId = int.Parse(ddlCountry.SelectedValue);

            string cs = ConfigurationManager.ConnectionStrings["B21AdoNetDB"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("usp_StatesByCountry", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CountryId", countryId);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            ddlState.Enabled = true;

            ddlState.DataValueField = "Id";
            ddlState.DataTextField = "Name";
            ddlState.DataSource = reader;
            ddlState.DataBind();

            ListItem li = new ListItem("-- Select State --", "-1");
            ddlState.Items.Insert(0, li);

            con.Close();
        }

        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            // fetch all cities by selected state
            int stateId = int.Parse(ddlState.SelectedValue);

            string cs = ConfigurationManager.ConnectionStrings["B21AdoNetDB"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("usp_CitiesByState", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@StateId", stateId);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            ddlCity.Enabled = true;

            ddlCity.DataValueField = "Id";
            ddlCity.DataTextField = "Name";
            ddlCity.DataSource = reader;
            ddlCity.DataBind();

            ListItem li = new ListItem("-- Select City --", "-1");
            ddlCity.Items.Insert(0, li);

            con.Close();
        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string country = ddlCountry.SelectedItem.Text;
            string state = ddlState.SelectedItem.Text;
            string city = ddlCity.SelectedItem.Text;

            lblLocation.Text = $"City : {city}<br/>State : {state} <br/>Country : {country}";
        }
    }

    class Customer : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}