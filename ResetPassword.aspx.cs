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
    public partial class ResetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Reset_Click(object sender, EventArgs e)
        {
            string newPassword1 = TextBox1.Text;
            string newPassword2 = TextBox2.Text;
            string email = Session["Email"].ToString();
            string connstr = WebConfigurationManager.ConnectionStrings["StudentsDB"].ConnectionString;
            SqlConnection con = new SqlConnection(connstr);

            if (newPassword1.Equals(newPassword2))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update Registered set Password = @Password where Email = @Email", con);

                    cmd.Parameters.AddWithValue("@Password", newPassword2);
                    cmd.Parameters.AddWithValue("@Email", email);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    con.Close();
                    Label3.Text = "Password successfully reset. Please Login again";
                }
            }
            else
            {
                Label3.Text = "The two passwords do not match. Please try again.";
            }
        }
    }
}
