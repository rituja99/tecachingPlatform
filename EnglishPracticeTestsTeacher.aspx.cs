﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Drawing;


namespace teachingPlatform
{
    public partial class EnglishPracticeTestsTeacher : System.Web.UI.Page
    {
		string connstr = WebConfigurationManager.ConnectionStrings["TeachingPlatform"].ConnectionString;
		protected void Page_Load(object sender, EventArgs e)
		{
			Site1 master = (Site1)this.Master;
			master.StudyMaterials.NavigateUrl = "EnglishStudyMaterialsTeacher.aspx";
			master.PracticeTests.NavigateUrl = "EnglishPracticeTestsTeacher.aspx";
			master.HomePage.NavigateUrl = "TeacherHomepage.aspx";
			master.DiscussionForum.NavigateUrl = "ENdiscussionForum.aspx";

			Panel1.Controls.Clear();
			Panel1.Controls.Add(new LiteralControl("<br/>"));

			SqlConnection con = new SqlConnection(connstr);
			SqlCommand command = new SqlCommand("SELECT Link, TestName FROM PracticeTests WHERE Language='English'", con);
			SqlDataReader reader;
			try
			{
				con.Open();
				reader = command.ExecuteReader();
				if (!reader.Read())
				{
					Label label = new Label();
					label.Text = "No tests uploaded";
					label.ForeColor = Color.FromArgb(247, 248, 255);
					Panel1.Controls.Add(label);
				}

				while (reader.Read())
				{
					Panel newPanel = new Panel();

					HyperLink hyperlink = new HyperLink();
					hyperlink.NavigateUrl = reader["Link"].ToString();
					hyperlink.Text = reader["TestName"].ToString();
					hyperlink.Target = "_blank";
					//hyperlink.ForeColor = Color.FromArgb(0, 97, 216);
					hyperlink.ForeColor = Color.FromArgb(247, 248, 255);

					newPanel.Controls.Add(hyperlink);

					Panel1.Controls.Add(newPanel);
					Panel1.Controls.Add(new LiteralControl("<br/>"));
				}
            }
            catch
            {

            }

		}

		protected void UploadButton_Click(object sender, EventArgs e)
		{
			if (IsValid)
			{

				SqlConnection con = new SqlConnection(connstr);
				if (TextBox1.Text != null && TextBox2.Text != null && TextBox1.Text.StartsWith("https://forms.office.com"))
				{
					string cmdStr = "select COUNT(*) as count from PracticeTests";
					SqlCommand cmd = new SqlCommand(cmdStr, con);
					SqlDataReader reader;
					try
					{
						con.Open();

						reader = cmd.ExecuteReader();
						reader.Read();
						int ID = int.Parse(reader["count"].ToString()) + 1;
						reader.Close();

      //                  string connstr2 = WebConfigurationManager.ConnectionStrings["StudentsDB"].ConnectionString;
      //                  SqlConnection con2 = new SqlConnection(connstr2);
      //                  SqlCommand command = new SqlCommand("SELECT * FROM Registered WHERE FullName = @FullName", con2);
      //                  command.Parameters.AddWithValue("@FullName", Session["Name"]);
      //                  reader = command.ExecuteReader();
      //                  reader.Read();
      //                  String Tid = reader["Id"].ToString();
						//reader.Close();


                        cmd.CommandText = "Insert into PracticeTests (Id, TeacherID, Language, Link, TestName) " +
						"Values(@Id, @TeacherID, @Language, @Link, @TestName)";
						cmd.Parameters.AddWithValue("@Id", ID);
						cmd.Parameters.AddWithValue("@TeacherID", "");
						cmd.Parameters.AddWithValue("@Language", "English");
						cmd.Parameters.AddWithValue("@Link", TextBox1.Text);
						cmd.Parameters.AddWithValue("@TestName", TextBox2.Text);
						cmd.ExecuteNonQuery();

						Label1.Text = TextBox2.Text + " uploaded.";
					
					}
					catch(Exception ex)
					{
						Label1.Text = ex.Message;
					}
					finally
					{
						con.Close();
						this.Page_Load(sender, e);
						TextBox1.Controls.Clear();
						TextBox2.Controls.Clear();
						Label1.Controls.Clear();
						this.Page_Load(sender, e);
					}
				}
				else
				{
					Label1.Text = "Test link and name have to be filled. Only MS Forms accepted";
				}
			}
		}
	}
}