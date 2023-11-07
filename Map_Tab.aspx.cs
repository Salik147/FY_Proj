using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication3
{
    public partial class Map_Tab : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();

            }
        }
        public void Bind()
        {
            String mycon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\usb\\fyp1\\WebApplication3\\WebApplication3\\App_Data\\Database1.mdf;Integrated Security=True";
            String myquery = "Select * from Map1";
            SqlConnection con = new SqlConnection(mycon);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }
    }
}