using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace teachingPlatform
{

    public partial class Site1 : System.Web.UI.MasterPage
    {
        public HyperLink HomePage
        {
            set
            {
                homePage.NavigateUrl = value.NavigateUrl;
            }
            get
            {
                return homePage;
            }
        }
        public HyperLink StudyMaterials
        {
            set
            {
                studyMaterials.NavigateUrl = value.NavigateUrl;
            }
            get
            {
                return studyMaterials;
            }
        }

        public HyperLink PracticeTests
        {
            set
            {
                practiceTests.NavigateUrl = value.NavigateUrl;
            }
            get
            {
                return practiceTests;
            }
        }
        public HyperLink DiscussionForum
        {
            set
            {
                discussion.NavigateUrl = value.NavigateUrl;
            }
            get
            {
                return discussion;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}