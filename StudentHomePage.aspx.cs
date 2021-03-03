using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace teachingPlatform
{
    public partial class StudentHomePage : System.Web.UI.Page
    {
        string connstr = WebConfigurationManager.ConnectionStrings["StudentsDB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
            {
                if (User.Identity.IsAuthenticated)
                {
                    Label1.Text = "Welcome " + User.Identity.Name;
                    HyperLink2.Text = "Log Out";
                    HyperLink2.NavigateUrl = "loginPage.aspx";
                    HyperLink1.Visible = false;
                    SqlConnection con = new SqlConnection(connstr);
                    string cmdstr = "Select Status from English where Email=@Email";
                    SqlCommand cmd = new SqlCommand(cmdstr, con);
                    cmd.Parameters.AddWithValue("@Email", User.Identity.Name.ToString());
                    SqlDataReader reader;
                    try
                    {
                        con.Open();
                        reader = cmd.ExecuteReader();
                        reader.Read();
                        if(reader["Status"].ToString()=="Ongoing")
                        {
                            english.Text = "Continue";
                        }
                        reader.Close();
                        cmd.CommandText = "Select Status from German where Email=@Emailid";
                        cmd.Parameters.AddWithValue("@Emailid", User.Identity.Name.ToString());
                        reader = cmd.ExecuteReader();
                        reader.Read();
                        if (reader["Status"].ToString() == "Ongoing")
                        {
                            german.Text = "Continue";
                        }
                    }
                    catch(Exception ex)
                    {

                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                    Response.Redirect("loginPage.aspx");

            }
        }


        protected void english_Click(object sender, EventArgs e)
        {
            if (english.Text.ToString() == "Join")
            {
                SqlConnection con = new SqlConnection(connstr);
                string cmdstr = "Select * from Registered where Email=@Email";
                SqlCommand cmd = new SqlCommand(cmdstr, con);
                cmd.Parameters.AddWithValue("@Email", User.Identity.Name);
                SqlDataReader reader;
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    cmd.CommandText = "insert into English(Id, Fullname, Email, Marks, Status)" +
                                             "values(@Id, @FullName, @emailid, @Marks, @Status)";
                    cmd.Parameters.AddWithValue("@Id", reader["Id"].ToString());
                    cmd.Parameters.AddWithValue("@FullName", reader["FullName"].ToString());
                    cmd.Parameters.AddWithValue("@emailid", reader["Email"].ToString());
                    cmd.Parameters.AddWithValue("@Marks", "0");
                    cmd.Parameters.AddWithValue("@Status", "Ongoing");
                    reader.Close();
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    label.Text = ex.Message;
                }
                finally
                {
                    con.Close();
                }
            }
           Response.Redirect("englishPage.aspx");
        }

        protected void german_Click(object sender, EventArgs e)
        {
            if (german.Text.ToString() == "Join")
            {
                SqlConnection con = new SqlConnection(connstr);
                string cmdstr = "Select * from Registered where Email=@Email";
                SqlCommand cmd = new SqlCommand(cmdstr, con);
                cmd.Parameters.AddWithValue("@Email", User.Identity.Name);
                SqlDataReader reader;
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    cmd.CommandText = "insert into German(Id, Fullname, Email, Marks, Status)" +
                                             "values(@Id, @FullName, @Email, @Marks, @Status)";
                    cmd.Parameters.AddWithValue("@Id", reader["Id"].ToString());
                    cmd.Parameters.AddWithValue("@FullName", reader["FullName"].ToString());
                    cmd.Parameters.AddWithValue("@Email", reader["Email"].ToString());
                    cmd.Parameters.AddWithValue("@Marks", 0);
                    cmd.Parameters.AddWithValue("@Status", "Ongoing");
                    reader.Close();
                    cmd.ExecuteNonQuery();
                    german.Text = "Continue";
                }
                catch (Exception ex)
                {
                    label.Text = ex.Message;
                }
                finally
                {
                    con.Close();
                }
            }
            Response.Redirect("germanPage.aspx");
        }
    }
}