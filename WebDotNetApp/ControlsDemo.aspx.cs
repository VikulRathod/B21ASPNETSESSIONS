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
            // genders we are retrieving from any data resource - db, xml file etc.

            if (!IsPostBack)
            {
                ListItem li1 = new ListItem("Male", "Male");
                ListItem li2 = new ListItem("Female", "Female");
                rblGender.Items.Add(li1);
                rblGender.Items.Add(li2);

                ListItem li3 = new ListItem("SSC", "SSC");
                ListItem li4 = new ListItem("HSC", "HSC");
                ListItem li5 = new ListItem("DIPLOMA", "DIPLOMA");
                ListItem li6 = new ListItem("DEGREE", "DEGREE");

                cblEducation.Items.Add(li3);
                cblEducation.Items.Add(li4);
                cblEducation.Items.Add(li5);
                cblEducation.Items.Add(li6);

                ListItem l1 = new ListItem("-- Select City --", "-1");
                ListItem l2 = new ListItem("Pune", "Pune");
                ListItem l3 = new ListItem("Mumbai", "Mumbai");
                ListItem l4 = new ListItem("Delhi", "Delhi");

                ddlCity.Items.Add(l1);
                ddlCity.Items.Add(l2);
                ddlCity.Items.Add(l3);
                ddlCity.Items.Add(l4);
            }
        }

        protected void btnGet_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            string gender = string.Empty;
            //if (rbMale.Checked)
            //{
            //    gender = rbMale.Text;
            //}
            //else if (rbFemale.Checked)
            //{
            //    gender = rbFemale.Text;
            //}
            //else
            //{
            //    gender = "Unknown";
            //}

            foreach (ListItem item in rblGender.Items)
            {
                if (item.Selected)
                {
                    gender = item.Value;
                    break;
                }
            }

            string education = string.Empty;
            //if (cbSSC.Checked)
            //{
            //    education += cbSSC.Text + ",";
            //}
            //if (cbHSC.Checked)
            //{
            //    education += cbHSC.Text + ",";
            //}
            //if (cbDiploma.Checked)
            //{
            //    education += cbDiploma.Text + ",";
            //}
            //if (cbDegree.Checked)
            //{
            //    education += cbDegree.Text + ",";
            //}

            foreach (ListItem item in cblEducation.Items)
            {
                if (item.Selected)
                {
                    education += item.Value + ",";
                }
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
            //rbMale.Checked = true;

            foreach (ListItem item in rblGender.Items)
            {
                if (item.Value == "Male")
                {
                    item.Selected = true;
                    break;
                }
            }

            //cbSSC.Checked = true;
            //cbHSC.Checked = true;

            foreach (ListItem item in cblEducation.Items)
            {
                if (item.Value == "SSC")
                {
                    item.Selected = true;
                }
                if (item.Value == "HSC")
                {
                    item.Selected = true;
                }
            }

            ddlCity.SelectedValue = "Mumbai";
        }
    }
}