using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace teachingPlatform
{
    public partial class DEdiscussionForum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Site1 master = (Site1)this.Master;
            master.StudyMaterials.NavigateUrl = "DEstudyMaterials.aspx";
            master.PracticeTests.NavigateUrl = "DEpracticeTests.aspx";
            master.HomePage.NavigateUrl = "StudentHomepage.aspx";
            master.DiscussionForum.NavigateUrl = "DEdiscussionForum.aspx";
        }

        protected void postAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}