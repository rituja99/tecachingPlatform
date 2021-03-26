using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace teachingPlatform
{
    public partial class ENstudyMaterials : System.Web.UI.Page
    {
        private string serverPath;
        private string filePath = "Data/resources/english/";
        protected void Page_Load(object sender, EventArgs e)
        {
            Site1 master = (Site1)this.Master;
            master.StudyMaterials.NavigateUrl = "ENstudyMaterials.aspx";
            master.PracticeTests.NavigateUrl = "ENpracticeTests.aspx";
            master.HomePage.NavigateUrl = "StudentHomepage.aspx";
            master.DiscussionForum.NavigateUrl = "ENdiscussionForum.aspx";
            serverPath = Server.MapPath(filePath);

            Panel1.Controls.Clear();
            Panel1.Controls.Add(new LiteralControl("<br/>"));

            string[] files = Directory.GetFiles(serverPath);

            if (files.Length == 0)
            {
                Label label = new Label();
                label.Text = "No materials uploaded";
                label.ForeColor = Color.FromArgb(247, 248, 255);
                Panel1.Controls.Add(label);
            }

            foreach (String file in files)
            {
                Panel newPanel = new Panel();
                //newPanel.BorderStyle = BorderStyle.Solid;
                //newPanel.BorderColor = Color.FromArgb(68, 126, 248);
                //newPanel.Width = Unit.Percentage(50);

                HyperLink hyperlink = new HyperLink();
                hyperlink.NavigateUrl = filePath + Path.GetFileName(file);
                hyperlink.Text = Path.GetFileName(file);
                hyperlink.Target = "_blank";
                //hyperlink.ForeColor = Color.FromArgb(0, 97, 216);
                hyperlink.ForeColor = Color.Black;
                hyperlink.Font.Underline = false;
                newPanel.Controls.Add(hyperlink);

                Panel1.Controls.Add(newPanel);
                Panel1.Controls.Add(new LiteralControl("<br/>"));
            }
        }
    }
}