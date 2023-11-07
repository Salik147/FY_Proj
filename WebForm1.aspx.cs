using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\usb\\fyp1\\WebApplication3\\WebApplication3\\App_Data\\Database1.mdf;Integrated Security=True";
            string filepath = Server.MapPath("~/video/") + Path.GetFileName(FileUpload1.FileName);
            FileUpload1.SaveAs(filepath);
            string link = "video/" + Path.GetFileName(FileUpload1.FileName);
            link = "<video width='800' controls><source src='" + link + "' type='video/mp4'></video>";

            string query = "INSERT INTO videodata (name, authorname, videolink) VALUES (@name, @author, @link)";

            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@author", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@link", link);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            Label2.Text = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\usb\\fyp1\\WebApplication3\\WebApplication3\\App_Data\\Database1.mdf;Integrated Security=True";
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\usb\\fyp1\\WebApplication3\\WebApplication3\\App_Data\\Database1.mdf;Integrated Security=True";
            string query = "DELETE FROM videodata WHERE name=@name";
            string name = TextBox1.Text;

            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            Label2.Text = "Video Data Has Been Deleted Successfully";
            TextBox1.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            {
                string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\usb\\fyp1\\WebApplication3\\WebApplication3\\App_Data\\Database1.mdf;Integrated Security=True";
                string filepath = Server.MapPath("~/pic/") + Path.GetFileName(FileUpload2.FileName);
                FileUpload2.SaveAs(filepath);
                string link = "pic/" + Path.GetFileName(FileUpload2.FileName);

                string query = "INSERT INTO Map1 ( Mapname  ,Mapimage) VALUES ( @Mapname , @Mapimage)";

                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Mapname", TextBox3.Text);
                        cmd.Parameters.AddWithValue("@Mapimage", link);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        
                    }
                }

                Label3.Text = @"Image Data has been uploaded and saved successfully";
                TextBox3.Text = "";
                TextBox2.Text = "";
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\usb\\fyp1\\WebApplication3\\WebApplication3\\App_Data\\Database1.mdf;Integrated Security=True";
            string imageName = TextBox3.Text;
            string query = "DELETE FROM Map1 WHERE Mapname = @Mapname";

            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Mapname", imageName);
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rowsAffected > 0)
                    {
                        // Image deleted successfully
                        Label3.Text = "Image has been deleted successfully";
                    }
                    else
                    {
                        // Image not found or deletion failed
                        Label3.Text = "Image not found or deletion failed";
                    }
                }
            }

            TextBox3.Text = "";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}