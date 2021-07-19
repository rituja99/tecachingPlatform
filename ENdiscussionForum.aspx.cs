using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace teachingPlatform
{
    public partial class discussionForum : System.Web.UI.Page
    {
        string connstr = WebConfigurationManager.ConnectionStrings["StudentsDB"].ConnectionString;

        protected void Fill_Page()
        {
            SqlConnection con = new SqlConnection(connstr);
            string cmdstr = "Select count(*) as count from ENDiscussion";
            SqlCommand cmd = new SqlCommand(cmdstr, con);
            SqlDataReader reader;
            SqlDataAdapter dataAdapter;
            DataSet set = new DataSet();
            int n = 0;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                n = int.Parse(reader["count"].ToString());
                if (n > 0)
                {
                    reader.Close();
                    cmd.CommandText = "Select * from ENDiscussion";
                    dataAdapter = new SqlDataAdapter(cmd);
                    dataAdapter.Fill(set, "enDiscuss");
                    //Cache["query"] = set.Tables["endDiscuss"];
                }
            }
            catch
            {
                
            }
            finally
            {
                con.Close();
                if (n > 0)
                {
                    Label[] label = new Label[n];
                    int i = 0;
                    panel.Height = Unit.Pixel(49 + n * 2);
                    foreach (DataRow row in set.Tables["enDiscuss"].Rows)
                    {
                        label[i] = new Label();
                        if (row["QUserName"].ToString() == "")
                        {
                            label[i].Text = row["AUserName"].ToString() + "</br>&nbsp&nbsp" +
                                row["Answer"].ToString() + "</br></br>";
                            panel.Controls.Add(label[i]);
                        }
                        else if (row["AUserName"].ToString() == "")
                        {
                            label[i].Text = row["QUserName"].ToString() + "</br>&nbsp&nbsp" +
                               row["Question"].ToString() + "</br></br>";
                            panel.Controls.Add(label[i]);
                        }
                    }
                }

            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Fill_Page();

            Site1 master = (Site1)this.Master;

            SqlConnection con = new SqlConnection(connstr);
            string query = "SELECT * FROM Registered WHERE FullName = '" + Session["Name"].ToString() + "'";//'@FullName'";
            SqlCommand command = new SqlCommand(query, con);
            //command.Parameters.AddWithValue("@FullName", Session["Name"].ToString());
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = command.ExecuteReader();
                reader.Read();
                if (reader["Id"].ToString().StartsWith("T"))
                {
                    master.StudyMaterials.NavigateUrl = "EnglishStudyMaterialsTeacher.aspx";
                    master.PracticeTests.NavigateUrl = "EnglishPracticeTestsTeacher.aspx";
                    master.HomePage.NavigateUrl = "TeacherHomepage.aspx";
                    master.DiscussionForum.NavigateUrl = "ENdiscussionForum.aspx";
                }
                else
                {
                    master.StudyMaterials.NavigateUrl = "ENstudyMaterials.aspx";
                    master.PracticeTests.NavigateUrl = "ENpracticeTests.aspx";
                    master.HomePage.NavigateUrl = "StudentHomepage.aspx";
                    master.DiscussionForum.NavigateUrl = "ENdiscussionForum.aspx";
                }
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
            
        }
        
        protected void postAnswer_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connstr);
            string cmdstr = "insert into ENDiscussion (QUserName, Question, Answer, AUserName)" +
                "values (@QUserName, @Question, @Answer, @AUserName)";
            SqlCommand cmd = new SqlCommand(cmdstr, con);
            cmd.Parameters.AddWithValue("@QUserName", "");
            cmd.Parameters.AddWithValue("@Question", "");
            cmd.Parameters.AddWithValue("@Answer", discussTB.Text);
            cmd.Parameters.AddWithValue("@AUserName", Session["Name"].ToString());
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch
            {

            }
            finally
            {
                con.Close();
                discussTB.Text = "";
                panel.Controls.Clear();
                Fill_Page();
            }
        }

        protected void postQuestion_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connstr);
            string cmdstr = "insert into ENDiscussion (QUserName, Question, Answer, AUserName)" +
                "values (@QUserName, @Question, @Answer, @AUserName)";
            SqlCommand cmd = new SqlCommand(cmdstr, con);
            cmd.Parameters.AddWithValue("@QUserName", Session["Name"].ToString());
            cmd.Parameters.AddWithValue("@Question", discussTB.Text);
            cmd.Parameters.AddWithValue("@Answer", "");
            cmd.Parameters.AddWithValue("@AUserName", "");
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch
            {
                
            }
            finally
            {
                con.Close();
                discussTB.Text = "";
                panel.Controls.Clear();
                Fill_Page();
            }
        }
    }
}