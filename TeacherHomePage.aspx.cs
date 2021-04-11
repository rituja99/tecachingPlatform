using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace teachingPlatform
{
    public partial class TeacherHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["fullName"] == null)
            {
                string fullName = Request.QueryString["fullName"];
                Session["fullName"] = fullName;
            }
            
            
            TeacherName.Text = Session["fullName"].ToString();


        }
    }
}