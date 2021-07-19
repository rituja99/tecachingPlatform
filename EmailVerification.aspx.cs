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
            if(!IsPostBack)
            {
				MailMessage mm = new MailMessage("teamLearn12@gmail.com", Session["Email"].ToString().Trim());
				mm.Subject = "Email Verification";
				mm.Body = string.Format("Hi {0},<br /><br />Verification completed. Please click on the below link to login.<br /><br /><a href=\"https://localhost:44308/signIn.aspx\">signIn</a> <br />Thank You,<br />Team Learn", Session["Name"].ToString());
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
    }
}