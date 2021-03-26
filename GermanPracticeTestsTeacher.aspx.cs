using System;
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
    public partial class GermanPracticeTestsTeacher : System.Web.UI.Page
    {
		string connstr = WebConfigurationManager.ConnectionStrings["TeachingPlatform"].ConnectionString;
		protected void Page_Load(object sender, EventArgs e)
        {
            Site1 master = (Site1)this.Master;
            master.StudyMaterials.NavigateUrl = "GermanStudyMaterialsTeacher.aspx";
            master.PracticeTests.NavigateUrl = "GermanPracticeTestsTeacher.aspx";
            master.HomePage.NavigateUrl = "TeacherHomepage.aspx";
            master.DiscussionForum.NavigateUrl = "DEdiscussionForum.aspx";

			Panel1.Controls.Clear();
			Panel1.Controls.Add(new LiteralControl("<br/>"));

			SqlConnection con = new SqlConnection(connstr);
			SqlCommand command = new SqlCommand("SELECT Link, TestName FROM PracticeTests WHERE Language='German'", con);
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
				if (TextBox1.Text != null && TextBox2.Text!=null)
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

						cmd.CommandText = "Insert into PracticeTests (Id, TeacherID, Language, Link, TestName) " +
						"Values(@Id, @TeacherID, @Language, @Link, @TestName)";
						cmd.Parameters.AddWithValue("@Id", ID);
						cmd.Parameters.AddWithValue("@TeacherID", ""); //fix
						cmd.Parameters.AddWithValue("@Language", "German");
						cmd.Parameters.AddWithValue("@Link", TextBox1.Text);
						cmd.Parameters.AddWithValue("@TestName", TextBox2.Text);
						cmd.ExecuteNonQuery();

						Label1.Text = TextBox2.Text + " uploaded.";

					}
					catch
					{
						Label1.Text = "Enter proper values";
					}
					finally
					{
						con.Close();
					}
				}
				else
				{
					Label1.Text = "Test link and name have to be filled";
				}
			}
		}
    }
}