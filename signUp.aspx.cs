using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Text;

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
					string passwordEncrypted = encryptpass(txt_password.Text);
					cmd.CommandText = "Insert into Registered (Id, FullName, Email, Password, English, German) Values(@Id, @FullName, @Email, @Password, @English, @German)";
					cmd.Parameters.AddWithValue("@Id", id);
					cmd.Parameters.AddWithValue("@FullName", txt_fullname.Text);
					cmd.Parameters.AddWithValue("@Email", txt_emailid.Text);
					cmd.Parameters.AddWithValue("@Password", passwordEncrypted);
					cmd.Parameters.AddWithValue("@English", "0");
					cmd.Parameters.AddWithValue("@German", "0");
					cmd.ExecuteNonQuery();

					Session["Name"] = txt_fullname.Text;
					Session["Email"] = txt_emailid.Text;
					Response.Redirect("EmailVerification.aspx");

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
		public string encryptpass(string password)
		{
			byte[] passBytes = System.Text.Encoding.Unicode.GetBytes(password);
			string encryptPassword = Convert.ToBase64String(passBytes);
			return encryptPassword;
		}

	}
}