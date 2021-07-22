using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;

namespace teachingPlatform
{
    public partial class EmailVerification : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			Site2 master = (Site2)this.Master;
			master.SignUp.Visible = false;
			master.SignIn.Visible = false;

			if (!IsPostBack)
            {	Random rnd = new Random();
				int otp = rnd.Next(300000, 700000);
				Session["OTP"] = otp;
				MailMessage mm = new MailMessage("teamLearn12@gmail.com", Session["Email"].ToString().Trim());
				mm.Subject = "Email Verification";
				mm.Body = string.Format("Hi {0},<br /><br />OTP: {1}<br />Thank You,<br />Team Learn", Session["Name"].ToString(), otp.ToString());
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
			}
        }

		protected void SubmitClick(object sender, EventArgs e)
        {
			if(TextBox1.Text == Session["OTP"].ToString())
            {
				Response.Redirect("signIn.aspx");
            }
            else
            {
				Label2.Text = "Please check your email";
            }
        }
    }
}