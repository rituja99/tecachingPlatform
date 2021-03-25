using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;

namespace teachingPlatform
{
    public partial class EnglishStudyMaterialsTeacher : System.Web.UI.Page
    {
        private string serverPath;
        protected void Page_Load(object sender, EventArgs e)
        {
            serverPath = Server.MapPath("Data/resources/english/");

            Panel1.Controls.Clear();
            Panel1.Controls.Add(new LiteralControl("<br/>"));

            string[] files = Directory.GetFiles(serverPath);

            foreach(String file in files)
            {
                Panel newPanel = new Panel();
                //newPanel.BorderStyle = BorderStyle.Solid;
                //newPanel.BorderColor = Color.FromArgb(68, 126, 248);
                //newPanel.Width = Unit.Percentage(50);

                HyperLink hyperlink = new HyperLink();
                hyperlink.NavigateUrl = "Data/resources/english/" + Path.GetFileName(file);
                hyperlink.Text = Path.GetFileName(file);
                hyperlink.Target = "_blank";
                //hyperlink.ForeColor = Color.FromArgb(0, 97, 216);
                hyperlink.ForeColor = Color.FromArgb(247, 248, 255);

                newPanel.Controls.Add(hyperlink);

                Panel1.Controls.Add(newPanel);
                Panel1.Controls.Add(new LiteralControl("<br/>"));
            }


        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string extension = Path.GetExtension(FileUpload1.PostedFile.FileName);
                if (extension == ".pdf")
                {
                    //FileUpload1.PostedFile.SaveAs(Path.Combine(filePath, FileUpload1.FileName));
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Data/resources/english/") + FileUpload1.FileName);//Server.MapPath("~") + "/App_Data/resources/english/" +  FileUpload1.FileName);
                    Label1.Text = FileUpload1.FileName + " uploaded.";

                    this.Page_Load(sender, e);
                }
                else
                    Label1.Text = "Only PDFs allowed.";
            }
            else
                Label1.Text = "No file selected";
        }
    }
}