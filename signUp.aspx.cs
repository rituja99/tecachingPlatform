﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace teachingPlatform
{
	public partial class signUp : System.Web.UI.Page
	{
		string connstr = WebConfigurationManager.ConnectionStrings["StudentsDB"].ConnectionString;
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void submitButton_Click(object sender, EventArgs e)
        {
			if (IsValid)
			{
				
				SqlConnection con = new SqlConnection(connstr);

				string cmdStr = "select COUNT(*) as count from Registered";
				SqlCommand cmd = new SqlCommand(cmdStr, con);
				SqlDataReader reader;

                try
                {
					con.Open();
					reader = cmd.ExecuteReader();
					reader.Read();

					string id;
					if(modeDropDownList.SelectedItem.Text == "Student")
						id = "S" + (int.Parse(reader["count"].ToString()) + 100).ToString();
					else
						id = "T" + (int.Parse(reader["count"].ToString()) + 100).ToString();

					reader.Close();

					cmd.CommandText = "Insert into Registered (Id, FullName, Email, Password, English, German) Values(@Id, @FullName, @Email, @Password, @English, @German)";
					cmd.Parameters.AddWithValue("@Id", id);
					cmd.Parameters.AddWithValue("@FullName", txt_fullname.Text);
					cmd.Parameters.AddWithValue("@Email", txt_emailid.Text);
					cmd.Parameters.AddWithValue("@Password", txt_password.Text);
					cmd.Parameters.AddWithValue("@English", "0");
					cmd.Parameters.AddWithValue("@German", "0");
					cmd.ExecuteNonQuery();

					Session["Name"] = txt_fullname.Text;

					if (modeDropDownList.SelectedItem.Text == "Student")
						Response.Redirect("StudentHomePage.aspx");
					else
						Response.Redirect("TeacherHomePage.aspx?fullName=" + Server.UrlEncode(txt_fullname.Text));

				}
				catch
				{
					Label1.Text = "This Email already exists.";
				}
				finally
				{
					con.Close();
				}
			}
		}
    }
}