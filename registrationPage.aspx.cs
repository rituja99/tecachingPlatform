using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace teachingPlatform
{
    public partial class registrationPage : System.Web.UI.Page
    {
        string connstr = WebConfigurationManager.ConnectionStrings["StudentsDB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
            {
				if(Application["SIdCount"] == null)
                {
					Application["SIdCount"] = 0;

				}
            }
        }

        protected void btn_register_Click(object sender, EventArgs e)
        {
            if(IsValid)
            {
                SqlConnection con = new SqlConnection(connstr);
                int id = 100 + (int)Application["SIdCount"];
                string sid = "S" + id.ToString();
                string cmdStr = "Insert into Registered (Id, FullName, Email, Password)" +
                    "Values(@Id, @FullName, @Email, @Password)";
                SqlCommand cmd = new SqlCommand(cmdStr, con);
                cmd.Parameters.AddWithValue("@Id", sid);
                cmd.Parameters.AddWithValue("@FullName", txt_fullname.Text);
                cmd.Parameters.AddWithValue("@Email", txt_emailid.Text);
                cmd.Parameters.AddWithValue("@Password", txt_password.Text);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery().ToString();
					Application["SIdCount"] = (int)Application["SIdCount"] + 1;
                }
                catch(Exception ex)
                {
                    error.Text = ex.Message;
                }
                finally
                {

                }
            }
        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            
        }

        protected void Unnamed_ServerValidate(object source, ServerValidateEventArgs args)
        {

        }

        protected void passwordValid_ServerValidate(object source, ServerValidateEventArgs args)
        {
			if (!((txt_password.Text.Length >= 6)
			&& (txt_password.Text.Length <= 15)))
			{
				args.IsValid = false;
				passwordValid.ErrorMessage = "Password length should range between 6 and 15 and should contain alphabets,\n digits, captital letters and special characers.";
				return;
			}

			// to check space 
			if (txt_password.Text.Contains(" "))
			{
				args.IsValid = false;
				passwordValid.ErrorMessage = "Password length should range between 6 and 15 and should contain alphabets,\n digits, captital letters and special characers.";
				return;
			}
			if (true)
			{
				int count = 0;

				// check digits from 0 to 9 
				for (int i = 0; i <= 9; i++)
				{

					// to convert int to string 
					String str1 = i.ToString();

					if (txt_password.Text.Contains(str1))
					{
						count = 1;
					}
				}
				if (count == 0)
				{
					args.IsValid = false;
					passwordValid.ErrorMessage = "Password length should range between 6 and 15 and should contain alphabets,\n digits, captital letters and special characers.";
					return;
				}
			}

			// for special characters 
			if (!(txt_password.Text.Contains("@") || txt_password.Text.Contains("#")
				|| txt_password.Text.Contains("!") || txt_password.Text.Contains("~")
				|| txt_password.Text.Contains("$") || txt_password.Text.Contains("%")
				|| txt_password.Text.Contains("^") || txt_password.Text.Contains("&")
				|| txt_password.Text.Contains("*") || txt_password.Text.Contains("(")
				|| txt_password.Text.Contains(")") || txt_password.Text.Contains("-")
				|| txt_password.Text.Contains("+") || txt_password.Text.Contains("/")
				|| txt_password.Text.Contains(":") || txt_password.Text.Contains(".")
				|| txt_password.Text.Contains(", ") ||txt_password.Text.Contains("<")
				|| txt_password.Text.Contains(">") || txt_password.Text.Contains("?")
				|| txt_password.Text.Contains("|")))
			{
				args.IsValid = false;
				passwordValid.ErrorMessage = "Password length should range between 6 and 15 and should contain alphabets,\n digits, captital letters and special characers.";
				return;
			}

			if (true)
			{
				int count = 0;

				// checking capital letters 
				for (int i = 65; i <= 90; i++)
				{

					// type casting 
					char c = (char)i;

					String str1 = c.ToString();
					if (txt_password.Text.Contains(str1))
					{
						count = 1;
					}
				}
				if (count == 0)
				{
					args.IsValid = false;
					passwordValid.ErrorMessage = "Password length should range between 6 and 15 and should contain alphabets,\n digits, captital letters and special characers.";
					return;
				}
			}

			if (true)
			{
				int count = 0;

				// checking small letters 
				for (int i = 90; i <= 122; i++)
				{

					// type casting 
					char c = (char)i;
					String str1 = c.ToString();

					if (txt_password.Text.Contains(str1))
					{
						count = 1;
					}
				}
				if (count == 0)
				{
					args.IsValid = false;
					passwordValid.ErrorMessage = "Password length should range between 6 and 15 and should contain alphabets,\n digits, captital letters and special characers.";
					return;
				}
			}

			// if all conditions fails 
			args.IsValid = true;
		}
    }
}