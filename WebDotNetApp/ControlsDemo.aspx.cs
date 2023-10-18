using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebDotNetApp
{
    public partial class ControlsDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGet_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            string gender = string.Empty;
            if (rbMale.Checked)
            {
                gender = rbMale.Text;
            }
            else if (rbFemale.Checked)
            {
                gender = rbFemale.Text;
            }
            else
            {
                gender = "Unknown";
            }

            string education = string.Empty;
            if (cbSSC.Checked)
            {
                education += cbSSC.Text + ",";
            }
            if (cbHSC.Checked)
            {
                education += cbHSC.Text + ",";
            }
            if (cbDiploma.Checked)
            {
                education += cbDiploma.Text + ",";
            }
            if (cbDegree.Checked)
            {
                education += cbDegree.Text + ",";
            }

            string city = ddlCity.SelectedItem.Text;

            Response.Write($"User Input: <br/>" +
                $"Name: {name} <br/>" +
                $"Address : {address} <br/>" +
                $"Gender : {gender} <br/>" +
                $"Education : {education.TrimEnd(',')} <br/>" +
                $"City : {city} <br/>");
        }

        protected void btnSet_Click(object sender, EventArgs e)
        {
            txtName.Text = "Vivek";
            txtAddress.Text = "Narhe, Pune";
            rbMale.Checked = true;
            
            cbSSC.Checked = true;
            cbHSC.Checked = true;

            ddlCity.SelectedValue = "2";
        }
    }
}