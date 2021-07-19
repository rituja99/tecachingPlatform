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
using System.Drawing;


namespace teachingPlatform
{
    public partial class ForgotPasswordStudent1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SendEmail_Click(object sender, EventArgs e)
        {
            string password = String.Empty;
            string FullName = String.Empty;
            string connstr = WebConfigurationManager.ConnectionStrings["StudentsDB"].ConnectionString;
            SqlConnection con = new SqlConnection(connstr);

            try
            {
                SqlCommand cmd = new SqlCommand("select FullName, Password from Registered where Email = @Email", con);

                cmd.Parameters.AddWithValue("@Email", TextBox1.Text);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()){
                    FullName = reader["FullName"].ToString();
                    password = reader["Password"].ToString();
                }
                Session["Email"] = TextBox1.Text;
            }
            catch
            {
                con.Close();
            }

            if (!string.IsNullOrEmpty(password)){

                MailMessage mm = new MailMessage("teamLearn12@gmail.com", TextBox1.Text.Trim());
                mm.Subject = "Password Recovery";
                mm.Body = string.Format("Hi {0},<br /><br />You have requested for a password reset. Please click on the below link to do so.<br /><br /><a href=\"https://localhost:44308/ResetPassword.aspx\">Reset</a> <br />Thank You,<br />Team Learn", FullName);
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                NetworkCredential networkcred = new NetworkCredential();
                networkcred.UserName = "teamLearn12@gmail.com";
                networkcred.Password = "Alohomora!";
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = networkcred;
                smtp.Port = 587;
                smtp.Send(mm);
                Label2.ForeColor = Color.DarkBlue;
                Label2.Text = "Password reset link has been sent to your email address.";
            }
            else
            {
                Label2.ForeColor = Color.Black;
                Label2.Text = "This email does not match any account. Please enter correct id";
            }
        }
    }
}