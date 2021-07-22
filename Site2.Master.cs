using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace teachingPlatform
{
    public partial class Site2 : System.Web.UI.MasterPage
    {
        public Button SignUp
        {
            set
            {
                signUpButton.Visible = value.Visible;
            }
            get
            {
                return signUpButton;
            }
        }

        public Button SignIn
        {
            set
            {
                signInButton.Visible = value.Visible;
            }
            get
            {
                return signInButton;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}