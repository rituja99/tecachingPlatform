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
	public partial class ENpracticeTests : System.Web.UI.Page
	{
		string connstr = WebConfigurationManager.ConnectionStrings["StudentsDB"].ConnectionString;
		protected void Page_Load(object sender, EventArgs e)
		{
			Site1 master = (Site1)this.Master;
			master.StudyMaterials.NavigateUrl = "ENstudyMaterials.aspx";
			master.PracticeTests.NavigateUrl = "ENpracticeTests.aspx";
			master.HomePage.NavigateUrl = "StudentHomepage.aspx";
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
				while (reader.Read())
				{
					Panel newPanel = new Panel();

					HyperLink hyperlink = new HyperLink();
					hyperlink.NavigateUrl = reader["Link"].ToString();
					hyperlink.Text = reader["TestName"].ToString();
					hyperlink.Target = "_blank";
					//hyperlink.ForeColor = Color.FromArgb(0, 97, 216);
					hyperlink.ForeColor = Color.Black;

					newPanel.Controls.Add(hyperlink);

					Panel1.Controls.Add(newPanel);
					Panel1.Controls.Add(new LiteralControl("<br/>"));
				}
			}
			catch(Exception ex)
			{
				Label label = new Label();
				label.Text = ex.Message;
				Panel1.Controls.Add(label);
			}

		}
	}
}