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
            if (IsValid)
            {
                SqlConnection con = new SqlConnection(connstr);
                string cmdStr = "select * from Registered where Email=@Email";
                SqlCommand cmd = new SqlCommand(cmdStr, con);
                cmd.Parameters.AddWithValue("Email", emailIDTextBoxStudent);
                SqlDataReader reader;
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader["Password"] != passwordTextBoxStudent)
                    {
                        WrongCredentialsStudent.Text = "Incorrect Password.";
                    }
                    else
                        Response.Redirect("StudentHomePage.aspx");
                }
                catch
                {
                    WrongCredentialsStudent.Text = "Incorrect UserName.";
                }
                finally
                {

                }
            }
            else
            {
                WrongCredentialsStudent.Text = "Incorrect UserName.";
            }
        }

        protected void teacherSignIn_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                SqlConnection con = new SqlConnection(connstr);
                string cmdStr = "select * from Registered where Email=@Email";
                SqlCommand cmd = new SqlCommand(cmdStr, con);
                cmd.Parameters.AddWithValue("Email", emailIDTextBoxTeacher);
                SqlDataReader reader;
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader["Password"] != passwordTextBoxTeacher)
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

                }
            }
        }
    }
}