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
    public partial class StudentHomePage : System.Web.UI.Page
    {
        string connstr = WebConfigurationManager.ConnectionStrings["StudentsDB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void submitButton0_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection(connstr);
                string cmdstr = "Select Status from English where FullName=@FullName";
                SqlCommand cmd = new SqlCommand(cmdstr, con);
                cmd.Parameters.AddWithValue("@FullName", Session["Name"].ToString());
                SqlDataReader reader;
                try
                {
                    con.Open();
                   // Response.Redirect("englishPage.aspx");
                }
                catch(Exception ex)
                {
                //label.Text = ex.Message;
                    con.Open();
                    cmd.CommandText = "Select * from Registered where FullName=@name";
                    cmd.Parameters.AddWithValue("@name", Session["Name"].ToString());
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    cmd.CommandText = "Insert into English (Id, FullName, Email, Marks, Status)" +
                            "values(@Id, @full, @Email, @Marks, @Status)";
                    cmd.Parameters.AddWithValue("@Id", reader["Id"].ToString());
                    cmd.Parameters.AddWithValue("@full", reader["FullName"].ToString());
                    cmd.Parameters.AddWithValue("@Email", reader["Email"].ToString());
                    cmd.Parameters.AddWithValue("@Marks", "0");
                    cmd.Parameters.AddWithValue("@Status", "Ongoing");
                    reader.Close();
                    cmd.ExecuteNonQuery();
                    
                }
                finally
                {
                    con.Close();
                    Response.Redirect("englishPage.aspx");
                }
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection(connstr);
                string cmdstr = "Select Status from German where FullName=@FullName";
                SqlCommand cmd = new SqlCommand(cmdstr, con);
                cmd.Parameters.AddWithValue("@FullName", Session["Name"].ToString());
                SqlDataReader reader;
                try
                {
                //Response.Redirect("germanPage.aspx");
                    con.Open();
                }
                catch
                { 
                    con.Open();
                    cmd.CommandText = "Select * from Registered where FullName=@name";
                    cmd.Parameters.AddWithValue("@name", Session["Name"].ToString());
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    cmd.CommandText = "Insert into German (Id, FullName, Email, Marks, Status)" +
                        "values(@Id, @full, @Email, @Marks, @Status)";
                    cmd.Parameters.AddWithValue("@Id", reader["Id"].ToString());
                    cmd.Parameters.AddWithValue("@full", reader["FullName"].ToString());
                    cmd.Parameters.AddWithValue("@Email", reader["Email"].ToString());
                    cmd.Parameters.AddWithValue("@Marks", "0");
                    cmd.Parameters.AddWithValue("@Status", "Ongoing");
                    reader.Close();
                    cmd.ExecuteNonQuery();
                    
            }
                finally
                {
                    con.Close();
                    Response.Redirect("germanPage.aspx");
                }
            
        }
    }
}