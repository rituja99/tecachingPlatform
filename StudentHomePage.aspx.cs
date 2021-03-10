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
                string cmdstr = "Select English from Registered where FullName=@FullName";
                SqlCommand cmd = new SqlCommand(cmdstr, con);
                cmd.Parameters.AddWithValue("@FullName", Session["Name"].ToString());
                SqlDataReader reader;
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    if(reader["English"].ToString()=="0")
                    {
                        reader.Close();
                        cmd.CommandText = "Select * from Registered where FullName=@name";
                        cmd.Parameters.AddWithValue("@name", Session["Name"].ToString());
                        reader = cmd.ExecuteReader();
                        reader.Read();
                        cmd.CommandText = "Insert into English (Id, FullName, Email, Marks, Status)" +
                                "values(@Id, @full, @Email, @Marks, @Status);" +
                                "Update Registered set English=1 where Id=@Id";
                        cmd.Parameters.AddWithValue("@Id", reader["Id"].ToString());
                        cmd.Parameters.AddWithValue("@full", reader["FullName"].ToString());
                        cmd.Parameters.AddWithValue("@Email", reader["Email"].ToString());
                        cmd.Parameters.AddWithValue("@Marks", "0");
                        cmd.Parameters.AddWithValue("@Status", "Ongoing");
                        reader.Close();
                        cmd.ExecuteNonQuery();
                    }
                    Response.Redirect("englishPage.aspx");
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

        protected void submitButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connstr);
            string cmdstr = "Select German from Registered where FullName=@FullName";
            SqlCommand cmd = new SqlCommand(cmdstr, con);
            cmd.Parameters.AddWithValue("@FullName", Session["Name"].ToString());
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader["German"].ToString() == "0")
                {
                    reader.Close();
                    cmd.CommandText = "Select * from Registered where FullName=@name";
                    cmd.Parameters.AddWithValue("@name", Session["Name"].ToString());
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    cmd.CommandText = "Insert into German (Id, FullName, Email, Marks, Status)" +
                            "values(@Id, @full, @Email, @Marks, @Status);" +
                            "Update Registered set German=1 where Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", reader["Id"].ToString());
                    cmd.Parameters.AddWithValue("@full", reader["FullName"].ToString());
                    cmd.Parameters.AddWithValue("@Email", reader["Email"].ToString());
                    cmd.Parameters.AddWithValue("@Marks", "0");
                    cmd.Parameters.AddWithValue("@Status", "Ongoing");
                    reader.Close();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                label.Text = ex.Message;
            }
            finally
            {
                con.Close();
                Response.Redirect("germanPage.aspx");
            }

        }
    }
}