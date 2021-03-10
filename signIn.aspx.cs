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

        protected void studentSignIn_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection(connstr);
                string cmdStr = "select * from Registered where Email=@Email";
                SqlCommand cmd = new SqlCommand(cmdStr, con);
                cmd.Parameters.AddWithValue("@Email", emailIDTextBoxStudent.Text);
                SqlDataReader reader = null;
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader["Password"].ToString() != passwordTextBoxStudent.Text)
                    {
                        WrongCredentialsStudent.Text = "Incorrect Password.";
                    }
                    else
                    {
                        Session["Name"] = reader["FullName"].ToString();
                        reader.Close();
                        Response.Redirect("StudentHomePage.aspx");
                    }
                }
                catch
                {
                    WrongCredentialsStudent.Text = "Incorrect UserName.";
                }
                finally
                {
                    con.Close();
                }
            
        }

        protected void teacherSignIn_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection(connstr);
                string cmdStr = "select * from Registered where Email=@Email";
                SqlCommand cmd = new SqlCommand(cmdStr, con);
                cmd.Parameters.AddWithValue("@Email", emailIDTextBoxTeacher.Text);
                SqlDataReader reader;
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader["Password"].ToString() != passwordTextBoxTeacher.Text)
                    {
                        WrongCredentialsTeacher.Text = "Incorrect Password.";
                    }
                    else
                        Response.Redirect("TeacherHomePage.aspx");
                }
                catch
                {
                    WrongCredentialsTeacher.Text = "Incorrect UserName.";
                }
                finally
                {
                    con.Close();
                }
            
        }
    }
}