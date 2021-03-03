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
    public partial class loginPage : System.Web.UI.Page
    {
        string connstr = WebConfigurationManager.ConnectionStrings["StudentsDB"].ConnectionString;
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            if(IsValid)
            {
                SqlConnection con = new SqlConnection(connstr);
                string cmdStr = "select * from Registered where Email=@Email";
                SqlCommand cmd = new SqlCommand(cmdStr, con);
                cmd.Parameters.AddWithValue("@Email", txt_Username.Text);
                SqlDataReader reader;
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader["Password"].ToString() != txt_password.Text)
                    {
                        WrongCredentials.Text = "Incorrect Password.";
                    }
                    else
                    {
                        Session["Name"]=reader["FullName"].ToString();
                        System.Web.Security.FormsAuthentication.SetAuthCookie(reader["Email"].ToString(), true);
                        Response.Redirect("StudentHomePage.aspx");
                    }
                        
                }
                catch
                {
                    WrongCredentials.Text = "Incorrect UserName.";
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}