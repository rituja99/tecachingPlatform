using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace teachingPlatform
{
    public partial class ENpracticeTests : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Site1 master = (Site1)this.Master;
            master.StudyMaterials.NavigateUrl = "ENstudyMaterials.aspx";
            master.PracticeTests.NavigateUrl = "ENpracticeTests.aspx";
            master.HomePage.NavigateUrl = "StudentHomepage.aspx";
            master.DiscussionForum.NavigateUrl = "ENdiscussionForum.aspx";
        }
    }
}